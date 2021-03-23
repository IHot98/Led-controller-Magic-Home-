using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicHome;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace Controller
{
    public partial class Form1 : Form
    {

        WasapiLoopbackCapture capture;
        float brightnes;
        static int bufferSize = (int)Math.Pow(2, 8);
        MMDevice device=null;

        
        




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
            await light.SetColorAsync(Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value));
            trackBarRed.Value = (int)numericUpDownRed.Value;
            colorWheel1.Color = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);

        }

        private async void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            await light.SetColorAsync(Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value));
            trackBarGreen.Value = (int)numericUpDownGreen.Value;


        }

        private async void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            await light.SetColorAsync(Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value));
            trackBarBlue.Value = (int)numericUpDownBlue.Value;

        }

        private async void PoweredON_CheckedChanged(object sender, EventArgs e)
        {
            if (PoweredON.Checked == true)
            {
                await light.TurnOnAsync();
                await Task.Delay(100);
                await light.SetColorAsync(Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value));
            }
            else
            {
                await light.TurnOffAsync();
                await Task.Delay(100);
            }
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            capture.StopRecording();
            capture.Dispose();
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

            
            WaveBuffer buffer = new WaveBuffer(e.Buffer);
            int bytesRec = e.BytesRecorded;

            VisualMusic(buffer, bytesRec);
            

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
               await light.SetColorAsync(Color.FromArgb((int)(0 * max), (int)(255 * max), (int)(0 * max)));
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
            if (radioButton3.Checked)
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
                await light.SetColorAsync(Color.FromArgb(0, 0, (int)(255 * max)));
            }
            if (radioButton4.Checked)
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
                await light.SetColorAsync(Color.FromArgb((int)(255 * max), 0, (int)(255 * max)));
            }
            if (radioButton5.Checked)
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
                await light.SetColorAsync(Color.FromArgb((int)(255 * max), (int)(255 * max), (int)(255 * max)));
            }
        }
        public double[] FFT(double[] data)
        {
            double[] fft = new double[data.Length];
            System.Numerics.Complex[] fftComplex = new System.Numerics.Complex[data.Length];
            for (int i = 0; i < data.Length; i++)
                fftComplex[i] = new System.Numerics.Complex(data[i], 0.0);
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
                fft[i] = fftComplex[i].Magnitude;
            return fft;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            light.Dispose();

            capture.StopRecording();
            capture.Dispose();
        }

        
    }
} 
