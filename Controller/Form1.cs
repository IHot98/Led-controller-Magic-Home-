using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicHome;
using NAudio.CoreAudioApi;
using NAudio.Dsp;
using NAudio.Wave;

namespace Controller
{
    public partial class Form1 : Form
    {

        WasapiLoopbackCapture capture;

        MMDevice device = null;
        Color Boja = Color.Black;
        private static int fftLength = (int)Math.Pow(2, 12);
        private SampleAggregator sampleAggregator = new SampleAggregator(fftLength);
        double[] magnitudes = new double[fftLength];
        bool SchmittState = false;
        bool SchmittStateProsloStanje = false;
        List<double> doubleList = new List<double>();
        List<Color> Boje = new List<Color> { Color.Red, Color.Blue, Color.Pink, Color.Purple, Color.Yellow };
        int BrojacBoje = 1;




        Light light = new Light("192.168.1.2")
        {
            AutoRefreshEnabled = true
        };
        public Form1()
        {
            InitializeComponent();

            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());





        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            await light.ConnectAsync();
            await light.TurnOnAsync();
            numericUpDownRed.Value = light.InitialColor.R;
            numericUpDownGreen.Value = light.InitialColor.G;
            numericUpDownBlue.Value = light.InitialColor.B;
            if (light.IsOn) { PoweredON.Checked = true; } else { PoweredON.Checked = false; }
            if (light.Connected) { Conected.Checked = true; } else { Conected.Checked = false; }
            await Task.Delay(20);

        }

        private async void SetColorBtn_Click(object sender, EventArgs e)
        {
            await light.SetColorAsync(Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value));
        }

        private async void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            Boja = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
            await light.SetColorAsync(Boja);
            trackBarRed.Value = (int)numericUpDownRed.Value;
            colorWheel1.Color = Boja;

        }

        private async void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            Boja = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
            await light.SetColorAsync(Boja);
            trackBarGreen.Value = (int)numericUpDownGreen.Value;


        }

        private async void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            Boja = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
            await light.SetColorAsync(Boja);
            trackBarBlue.Value = (int)numericUpDownBlue.Value;

        }

        private async void PoweredON_CheckedChanged(object sender, EventArgs e)
        {
            if (PoweredON.Checked == true)
            {
                await light.TurnOnAsync();
                await Task.Delay(100);
                await light.SetColorAsync(Boja);
            }
            else
            {
                await light.TurnOffAsync();
                await Task.Delay(100);
            }
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capture != null)
            {
                capture.StopRecording();
                capture.Dispose();
            }
            await light.RestoreAsync();
            await Task.Delay(100);
            light.Dispose();

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            numericUpDownRed.Value = trackBarRed.Value;

        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            numericUpDownGreen.Value = trackBarGreen.Value;

        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            numericUpDownBlue.Value = trackBarBlue.Value;
        }

        private void colorWheel1_ColorChanged(object sender, EventArgs e)
        {
            numericUpDownRed.Value = colorWheel1.Color.R;
            numericUpDownGreen.Value = colorWheel1.Color.G;
            numericUpDownBlue.Value = colorWheel1.Color.B;
            pictureBox1.BackColor = colorWheel1.Color;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = (MMDevice)comboBox1.SelectedItem;
            if (capture != null) { capture.Dispose(); }

        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            if (device == null)
            {
                capture = new WasapiLoopbackCapture();
                capture.DataAvailable += Capture_DataAvailable;
                capture.RecordingStopped += Capture_RecordingStopped;
                sampleAggregator.FftCalculated += new EventHandler<FftEventArgs>(FftCalculated);
                sampleAggregator.PerformFFT = true;

            }
            else
            {

                capture = new WasapiLoopbackCapture(device);
                capture.DataAvailable += Capture_DataAvailable;
                capture.RecordingStopped += Capture_RecordingStopped;
            }
            if (capture.CaptureState != (CaptureState)2)
            {
                capture.StartRecording();
            }



        }

        private void Capture_RecordingStopped(object sender, StoppedEventArgs e)
        {
            capture.StopRecording();


        }

        private void Capture_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(Capture_DataAvailable), sender, e);
            }
            else
            {
                byte[] buffer = e.Buffer;
                int bytesRecorded = e.BytesRecorded;
                int bufferIncrement = capture.WaveFormat.BlockAlign;

                for (int index = 0; index < bytesRecorded; index += bufferIncrement)
                {
                    float sample32 = BitConverter.ToSingle(buffer, index);
                    sampleAggregator.Add(sample32);
                }
            }

            WaveBuffer Sample = new WaveBuffer(e.Buffer);
            int bytesRec = e.BytesRecorded;

            VisualMusic(Sample, bytesRec);


        }

        void FftCalculated(object sender, FftEventArgs e)
        {
            float[] max = new float[25];

            for (int i = 0; i < e.Result.Length; i++)
            {
                magnitudes[i] = Math.Sqrt(Math.Pow(e.Result[i].X, 2) + Math.Pow(e.Result[i].Y, 2));


            }
            for (int i = 0; i < 25; i++)
            {
                if (magnitudes[i] > max[i])
                {
                    max[i] = (float)magnitudes[i];
                }
            }
            /*
             volumeMeter1.Amplitude =(float) magnitudes[1];
             volumeMeter2.Amplitude = (float)magnitudes[2];
             volumeMeter3.Amplitude = (float)magnitudes[3];
             volumeMeter4.Amplitude = (float)magnitudes[4];
             volumeMeter5.Amplitude = (float)magnitudes[5];
             volumeMeter6.Amplitude = (float)magnitudes[6];
             volumeMeter7.Amplitude = (float)magnitudes[7];
             volumeMeter8.Amplitude = (float)magnitudes[8];
             volumeMeter9.Amplitude = (float)magnitudes[9];
             volumeMeter10.Amplitude = (float)magnitudes[10];
             volumeMeter11.Amplitude = (float)magnitudes[11];
             volumeMeter12.Amplitude = (float)magnitudes[12];
             volumeMeter13.Amplitude = (float)magnitudes[13];
             volumeMeter14.Amplitude = (float)magnitudes[14];
             volumeMeter15.Amplitude = (float)magnitudes[15];
             volumeMeter16.Amplitude = (float)magnitudes[16];
             volumeMeter17.Amplitude = (float)magnitudes[17];
             volumeMeter18.Amplitude = (float)magnitudes[18];
             volumeMeter19.Amplitude = (float)magnitudes[19];
             volumeMeter20.Amplitude = (float)magnitudes[20];
             volumeMeter21.Amplitude = (float)magnitudes[21];
             volumeMeter22.Amplitude = (float)magnitudes[22];
             volumeMeter23.Amplitude = (float)magnitudes[23];
             volumeMeter24.Amplitude = (float)magnitudes[24];
             */
            volumeMeter1.Amplitude = max[1];
            volumeMeter2.Amplitude = max[2];
            volumeMeter3.Amplitude = max[3];
            volumeMeter4.Amplitude = max[4];
            volumeMeter5.Amplitude = max[5];
            volumeMeter6.Amplitude = max[6];
            volumeMeter7.Amplitude = max[7];
            volumeMeter8.Amplitude = max[8];
            volumeMeter9.Amplitude = max[9];
            volumeMeter10.Amplitude = max[10];
            volumeMeter11.Amplitude = max[11];
            volumeMeter12.Amplitude = max[12];
            volumeMeter13.Amplitude = max[13];
            volumeMeter14.Amplitude = max[14];
            volumeMeter15.Amplitude = max[15];
            volumeMeter16.Amplitude = max[16];
            volumeMeter17.Amplitude = max[17];
            volumeMeter18.Amplitude = max[18];
            volumeMeter19.Amplitude = max[19];
            volumeMeter20.Amplitude = max[20];
            volumeMeter21.Amplitude = max[21];
            volumeMeter22.Amplitude = max[22];
            volumeMeter23.Amplitude = max[23];
            volumeMeter24.Amplitude = max[24];
            VisualMusic(max[1] * 2 + max[2] * 2);
            for (int i = 0; i < 25; i++)
            {
                max[i] = 0;
            }


        }



        private async void stopBtn_Click(object sender, EventArgs e)
        {
            capture.StopRecording();
            capture.Dispose();

            numericUpDownRed.Value = light.InitialColor.R;
            numericUpDownGreen.Value = light.InitialColor.G;
            numericUpDownBlue.Value = light.InitialColor.B;
            await Task.Delay(500);
            await light.SetColorAsync(Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value));


        }

        private double getStandardDeviation(List<double> doubleList)
        {
            double average = doubleList.Average();
            double sumOfDerivation = 0;
            foreach (double value in doubleList)
            {
                sumOfDerivation += (value) * (value);
            }
            double sumOfDerivationAverage = sumOfDerivation / (doubleList.Count - 1);
            return Math.Sqrt(sumOfDerivationAverage - (average * average));
        }
        public async void VisualMusic(float max)
        {

            if (doubleList.Count() >= 100)
            {
                doubleList.Clear();

            }
            doubleList.Add(max);

            if (radioButton3.Checked)
            {

                await light.SetColorAsync(Color.FromArgb(0, 0, (int)(255 * max)));
            }
            if (radioButton4.Checked)
            {


                if (max > doubleList.Average() + getStandardDeviation(doubleList))
                {
                    SchmittState = true;
                }
                if (max < doubleList.Average() - getStandardDeviation(doubleList) / 2)
                {
                    SchmittState = false;
                }
                if (SchmittState)
                {
                    if (max > 0.05)
                    {
                        await light.SetColorAsync(Color.FromArgb(255, 0, 255));
                    }
                    else
                    {
                        await light.SetColorAsync(Color.FromArgb((int)(255 * max * 1.5), 0, (int)(255 * max * 1.5)));
                    }
                }
                else
                {
                    await light.SetColorAsync(Color.FromArgb(0, 0, 0));
                }

            }

            if (radioButton5.Checked)
            {
                SchmittStateProsloStanje = SchmittState;
                if (max > doubleList.Average() + getStandardDeviation(doubleList) * 1.5 && max > 0.005)
                {
                    SchmittState = true;
                }
                if (max < doubleList.Average() - getStandardDeviation(doubleList) / 2)
                {
                    SchmittState = false;
                }
                if (SchmittState == true && SchmittStateProsloStanje == true)
                {
                    if (light.Color != Boje.ElementAt(BrojacBoje))
                    {
                        await light.SetColorAsync(Boje.ElementAt(BrojacBoje));
                        await Task.Delay(100);

                    }
                    SchmittState = false;
                    SchmittStateProsloStanje = false;
                    BrojacBoje++;


                }

                if (BrojacBoje >= Boje.Count())
                {
                    BrojacBoje = 0;
                }

            }
        }
        public async void VisualMusic(WaveBuffer buffer, int bytesRecorded)
        {
            if (radioButton1.Checked)
            {
                float max = 0;
                // interpret as 32 bit floating point audio
                for (int index = 0; index < bytesRecorded / 8; index++)
                {
                    float sample = buffer.FloatBuffer[index];

                    // absolute value 
                    if (sample < 0) sample = -sample;
                    // is this the max value?
                    if (sample > max) max = sample;


                }
                await light.SetColorAsync(Color.FromArgb((int)(Boja.R * max), (int)(Boja.G * max), (int)(Boja.B * max)));
            }
            if (radioButton2.Checked)
            {
                float max = 0;
                // interpret as 32 bit floating point audio
                for (int index = 0; index < bytesRecorded / 8; index++)
                {
                    var sample = buffer.FloatBuffer[index];

                    // absolute value 
                    if (sample < 0) sample = -sample;
                    // is this the max value?
                    if (sample > max) max = sample;


                }
                await light.SetColorAsync(Color.FromArgb((int)(255 * max), (int)(0 * max), (int)(0 * max)));
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            light.Dispose();
            if (capture != null)
            {
                capture.StopRecording();
                capture.Dispose();
            }
        }




    }

    class SampleAggregator
    {
        // FFT
        public event EventHandler<FftEventArgs> FftCalculated;
        public bool PerformFFT { get; set; }

        // This Complex is NAudio's own! 
        private Complex[] fftBuffer;
        private System.Numerics.Complex[] fftBuffer2;
        private FftEventArgs fftArgs;
        private int fftPos;
        private int fftLength;
        private int m;

        public SampleAggregator(int fftLength)
        {
            if (!IsPowerOfTwo(fftLength))
            {
                throw new ArgumentException("FFT Length must be a power of two");
            }
            this.m = (int)Math.Log(fftLength, 2.0);
            this.fftLength = fftLength;
            this.fftBuffer = new Complex[fftLength];
            this.fftBuffer2 = new System.Numerics.Complex[fftLength];

            this.fftArgs = new FftEventArgs(fftBuffer);
        }

        bool IsPowerOfTwo(int x)
        {
            return (x & (x - 1)) == 0;
        }

        public void Add(float value)
        {
            if (PerformFFT && FftCalculated != null)
            {
                // Remember the window function! There are many others as well.
                fftBuffer[fftPos].X = (float)(value * FastFourierTransform.HammingWindow(fftPos, fftLength));
                fftBuffer[fftPos].Y = 0; // This is always zero with audio.

                fftPos++;
                if (fftPos >= fftLength)
                {
                    fftPos = 0;

                    FastFourierTransform.FFT(true, m, fftBuffer);
                    FftCalculated(this, fftArgs);
                }
            }
        }
    }

    public class FftEventArgs : EventArgs
    {
        [DebuggerStepThrough]
        public FftEventArgs(Complex[] result)
        {
            this.Result = result;
        }
        public Complex[] Result { get; private set; }
    }
}
