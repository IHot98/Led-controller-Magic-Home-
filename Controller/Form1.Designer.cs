
namespace Controller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SetColorBtn = new System.Windows.Forms.Button();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pot2 = new NAudio.Gui.Pot();
            this.pot1 = new NAudio.Gui.Pot();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.volumeMeter24 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter23 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter22 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter21 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter20 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter19 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter18 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter17 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter16 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter15 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter14 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter13 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter12 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter11 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter10 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter9 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter8 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter7 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter6 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter5 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter4 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter3 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter2 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.label1 = new System.Windows.Forms.Label();
            this.PoweredON = new System.Windows.Forms.CheckBox();
            this.Conected = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(6, 155);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(302, 302);
            this.colorWheel1.TabIndex = 0;
            this.colorWheel1.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(355, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Size = new System.Drawing.Size(100, 269);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 486);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SetColorBtn);
            this.tabPage1.Controls.Add(this.numericUpDownGreen);
            this.tabPage1.Controls.Add(this.numericUpDownBlue);
            this.tabPage1.Controls.Add(this.numericUpDownRed);
            this.tabPage1.Controls.Add(this.trackBarBlue);
            this.tabPage1.Controls.Add(this.trackBarGreen);
            this.tabPage1.Controls.Add(this.trackBarRed);
            this.tabPage1.Controls.Add(this.colorWheel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SetColorBtn
            // 
            this.SetColorBtn.Location = new System.Drawing.Point(491, 412);
            this.SetColorBtn.Name = "SetColorBtn";
            this.SetColorBtn.Size = new System.Drawing.Size(222, 42);
            this.SetColorBtn.TabIndex = 8;
            this.SetColorBtn.Text = "Set Color";
            this.SetColorBtn.UseVisualStyleBackColor = true;
            this.SetColorBtn.Click += new System.EventHandler(this.SetColorBtn_Click);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(584, 375);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownGreen.TabIndex = 7;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(669, 375);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownBlue.TabIndex = 6;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(491, 375);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownRed.TabIndex = 5;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(491, 308);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(222, 45);
            this.trackBarBlue.TabIndex = 4;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(491, 257);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(222, 45);
            this.trackBarGreen.TabIndex = 3;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarRed.Location = new System.Drawing.Point(491, 206);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(222, 45);
            this.trackBarRed.TabIndex = 2;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pot2);
            this.tabPage2.Controls.Add(this.pot1);
            this.tabPage2.Controls.Add(this.radioButton5);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.stopBtn);
            this.tabPage2.Controls.Add(this.startBtn);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // pot2
            // 
            this.pot2.Location = new System.Drawing.Point(450, 300);
            this.pot2.Maximum = 2D;
            this.pot2.Minimum = 0D;
            this.pot2.Name = "pot2";
            this.pot2.Size = new System.Drawing.Size(32, 32);
            this.pot2.TabIndex = 10;
            this.pot2.Value = 0.05D;
            // 
            // pot1
            // 
            this.pot1.Location = new System.Drawing.Point(450, 232);
            this.pot1.Maximum = 2D;
            this.pot1.Minimum = 0D;
            this.pot1.Name = "pot1";
            this.pot1.Size = new System.Drawing.Size(32, 32);
            this.pot1.TabIndex = 9;
            this.pot1.Value = 0.1D;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(30, 174);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(30, 151);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(30, 128);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(30, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 81);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 411);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(247, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(580, 42);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(498, 43);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.volumeMeter24);
            this.tabPage3.Controls.Add(this.volumeMeter23);
            this.tabPage3.Controls.Add(this.volumeMeter22);
            this.tabPage3.Controls.Add(this.volumeMeter21);
            this.tabPage3.Controls.Add(this.volumeMeter20);
            this.tabPage3.Controls.Add(this.volumeMeter19);
            this.tabPage3.Controls.Add(this.volumeMeter18);
            this.tabPage3.Controls.Add(this.volumeMeter17);
            this.tabPage3.Controls.Add(this.volumeMeter16);
            this.tabPage3.Controls.Add(this.volumeMeter15);
            this.tabPage3.Controls.Add(this.volumeMeter14);
            this.tabPage3.Controls.Add(this.volumeMeter13);
            this.tabPage3.Controls.Add(this.volumeMeter12);
            this.tabPage3.Controls.Add(this.volumeMeter11);
            this.tabPage3.Controls.Add(this.volumeMeter10);
            this.tabPage3.Controls.Add(this.volumeMeter9);
            this.tabPage3.Controls.Add(this.volumeMeter8);
            this.tabPage3.Controls.Add(this.volumeMeter7);
            this.tabPage3.Controls.Add(this.volumeMeter6);
            this.tabPage3.Controls.Add(this.volumeMeter5);
            this.tabPage3.Controls.Add(this.volumeMeter4);
            this.tabPage3.Controls.Add(this.volumeMeter3);
            this.tabPage3.Controls.Add(this.volumeMeter2);
            this.tabPage3.Controls.Add(this.volumeMeter1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // volumeMeter24
            // 
            this.volumeMeter24.Amplitude = 0F;
            this.volumeMeter24.Location = new System.Drawing.Point(420, 96);
            this.volumeMeter24.MaxDb = 0F;
            this.volumeMeter24.MinDb = -80F;
            this.volumeMeter24.Name = "volumeMeter24";
            this.volumeMeter24.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter24.TabIndex = 25;
            this.volumeMeter24.Text = "volumeMeter24";
            // 
            // volumeMeter23
            // 
            this.volumeMeter23.Amplitude = 0F;
            this.volumeMeter23.Location = new System.Drawing.Point(404, 96);
            this.volumeMeter23.MaxDb = 0F;
            this.volumeMeter23.MinDb = -80F;
            this.volumeMeter23.Name = "volumeMeter23";
            this.volumeMeter23.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter23.TabIndex = 24;
            this.volumeMeter23.Text = "volumeMeter23";
            // 
            // volumeMeter22
            // 
            this.volumeMeter22.Amplitude = 0F;
            this.volumeMeter22.Location = new System.Drawing.Point(388, 96);
            this.volumeMeter22.MaxDb = 0F;
            this.volumeMeter22.MinDb = -80F;
            this.volumeMeter22.Name = "volumeMeter22";
            this.volumeMeter22.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter22.TabIndex = 23;
            this.volumeMeter22.Text = "volumeMeter22";
            // 
            // volumeMeter21
            // 
            this.volumeMeter21.Amplitude = 0F;
            this.volumeMeter21.Location = new System.Drawing.Point(372, 96);
            this.volumeMeter21.MaxDb = 0F;
            this.volumeMeter21.MinDb = -80F;
            this.volumeMeter21.Name = "volumeMeter21";
            this.volumeMeter21.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter21.TabIndex = 22;
            this.volumeMeter21.Text = "volumeMeter21";
            // 
            // volumeMeter20
            // 
            this.volumeMeter20.Amplitude = 0F;
            this.volumeMeter20.Location = new System.Drawing.Point(356, 96);
            this.volumeMeter20.MaxDb = 0F;
            this.volumeMeter20.MinDb = -80F;
            this.volumeMeter20.Name = "volumeMeter20";
            this.volumeMeter20.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter20.TabIndex = 21;
            this.volumeMeter20.Text = "volumeMeter20";
            // 
            // volumeMeter19
            // 
            this.volumeMeter19.Amplitude = 0F;
            this.volumeMeter19.Location = new System.Drawing.Point(340, 96);
            this.volumeMeter19.MaxDb = 0F;
            this.volumeMeter19.MinDb = -80F;
            this.volumeMeter19.Name = "volumeMeter19";
            this.volumeMeter19.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter19.TabIndex = 20;
            this.volumeMeter19.Text = "volumeMeter19";
            // 
            // volumeMeter18
            // 
            this.volumeMeter18.Amplitude = 0F;
            this.volumeMeter18.Location = new System.Drawing.Point(324, 96);
            this.volumeMeter18.MaxDb = 0F;
            this.volumeMeter18.MinDb = -80F;
            this.volumeMeter18.Name = "volumeMeter18";
            this.volumeMeter18.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter18.TabIndex = 19;
            this.volumeMeter18.Text = "volumeMeter18";
            // 
            // volumeMeter17
            // 
            this.volumeMeter17.Amplitude = 0F;
            this.volumeMeter17.Location = new System.Drawing.Point(308, 96);
            this.volumeMeter17.MaxDb = 0F;
            this.volumeMeter17.MinDb = -80F;
            this.volumeMeter17.Name = "volumeMeter17";
            this.volumeMeter17.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter17.TabIndex = 18;
            this.volumeMeter17.Text = "volumeMeter17";
            // 
            // volumeMeter16
            // 
            this.volumeMeter16.Amplitude = 0F;
            this.volumeMeter16.Location = new System.Drawing.Point(292, 96);
            this.volumeMeter16.MaxDb = 0F;
            this.volumeMeter16.MinDb = -80F;
            this.volumeMeter16.Name = "volumeMeter16";
            this.volumeMeter16.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter16.TabIndex = 17;
            this.volumeMeter16.Text = "volumeMeter16";
            // 
            // volumeMeter15
            // 
            this.volumeMeter15.Amplitude = 0F;
            this.volumeMeter15.Location = new System.Drawing.Point(276, 96);
            this.volumeMeter15.MaxDb = 0F;
            this.volumeMeter15.MinDb = -80F;
            this.volumeMeter15.Name = "volumeMeter15";
            this.volumeMeter15.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter15.TabIndex = 16;
            this.volumeMeter15.Text = "volumeMeter15";
            // 
            // volumeMeter14
            // 
            this.volumeMeter14.Amplitude = 0F;
            this.volumeMeter14.Location = new System.Drawing.Point(260, 96);
            this.volumeMeter14.MaxDb = 0F;
            this.volumeMeter14.MinDb = -80F;
            this.volumeMeter14.Name = "volumeMeter14";
            this.volumeMeter14.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter14.TabIndex = 15;
            this.volumeMeter14.Text = "volumeMeter14";
            // 
            // volumeMeter13
            // 
            this.volumeMeter13.Amplitude = 0F;
            this.volumeMeter13.Location = new System.Drawing.Point(244, 96);
            this.volumeMeter13.MaxDb = 0F;
            this.volumeMeter13.MinDb = -80F;
            this.volumeMeter13.Name = "volumeMeter13";
            this.volumeMeter13.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter13.TabIndex = 14;
            this.volumeMeter13.Text = "volumeMeter13";
            // 
            // volumeMeter12
            // 
            this.volumeMeter12.Amplitude = 0F;
            this.volumeMeter12.Location = new System.Drawing.Point(228, 96);
            this.volumeMeter12.MaxDb = 0F;
            this.volumeMeter12.MinDb = -80F;
            this.volumeMeter12.Name = "volumeMeter12";
            this.volumeMeter12.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter12.TabIndex = 13;
            this.volumeMeter12.Text = "volumeMeter12";
            // 
            // volumeMeter11
            // 
            this.volumeMeter11.Amplitude = 0F;
            this.volumeMeter11.Location = new System.Drawing.Point(212, 96);
            this.volumeMeter11.MaxDb = 0F;
            this.volumeMeter11.MinDb = -80F;
            this.volumeMeter11.Name = "volumeMeter11";
            this.volumeMeter11.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter11.TabIndex = 12;
            this.volumeMeter11.Text = "volumeMeter11";
            // 
            // volumeMeter10
            // 
            this.volumeMeter10.Amplitude = 0F;
            this.volumeMeter10.Location = new System.Drawing.Point(196, 96);
            this.volumeMeter10.MaxDb = 0F;
            this.volumeMeter10.MinDb = -80F;
            this.volumeMeter10.Name = "volumeMeter10";
            this.volumeMeter10.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter10.TabIndex = 11;
            this.volumeMeter10.Text = "volumeMeter10";
            // 
            // volumeMeter9
            // 
            this.volumeMeter9.Amplitude = 0F;
            this.volumeMeter9.Location = new System.Drawing.Point(180, 96);
            this.volumeMeter9.MaxDb = 0F;
            this.volumeMeter9.MinDb = -80F;
            this.volumeMeter9.Name = "volumeMeter9";
            this.volumeMeter9.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter9.TabIndex = 10;
            this.volumeMeter9.Text = "volumeMeter9";
            // 
            // volumeMeter8
            // 
            this.volumeMeter8.Amplitude = 0F;
            this.volumeMeter8.Location = new System.Drawing.Point(164, 96);
            this.volumeMeter8.MaxDb = 0F;
            this.volumeMeter8.MinDb = -80F;
            this.volumeMeter8.Name = "volumeMeter8";
            this.volumeMeter8.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter8.TabIndex = 9;
            this.volumeMeter8.Text = "volumeMeter8";
            // 
            // volumeMeter7
            // 
            this.volumeMeter7.Amplitude = 0F;
            this.volumeMeter7.Location = new System.Drawing.Point(148, 96);
            this.volumeMeter7.MaxDb = 0F;
            this.volumeMeter7.MinDb = -80F;
            this.volumeMeter7.Name = "volumeMeter7";
            this.volumeMeter7.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter7.TabIndex = 8;
            this.volumeMeter7.Text = "volumeMeter7";
            // 
            // volumeMeter6
            // 
            this.volumeMeter6.Amplitude = 0F;
            this.volumeMeter6.Location = new System.Drawing.Point(132, 96);
            this.volumeMeter6.MaxDb = 0F;
            this.volumeMeter6.MinDb = -80F;
            this.volumeMeter6.Name = "volumeMeter6";
            this.volumeMeter6.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter6.TabIndex = 7;
            this.volumeMeter6.Text = "volumeMeter6";
            // 
            // volumeMeter5
            // 
            this.volumeMeter5.Amplitude = 0F;
            this.volumeMeter5.Location = new System.Drawing.Point(116, 96);
            this.volumeMeter5.MaxDb = 0F;
            this.volumeMeter5.MinDb = -80F;
            this.volumeMeter5.Name = "volumeMeter5";
            this.volumeMeter5.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter5.TabIndex = 6;
            this.volumeMeter5.Text = "volumeMeter5";
            // 
            // volumeMeter4
            // 
            this.volumeMeter4.Amplitude = 0F;
            this.volumeMeter4.Location = new System.Drawing.Point(100, 96);
            this.volumeMeter4.MaxDb = 0F;
            this.volumeMeter4.MinDb = -80F;
            this.volumeMeter4.Name = "volumeMeter4";
            this.volumeMeter4.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter4.TabIndex = 5;
            this.volumeMeter4.Text = "volumeMeter4";
            // 
            // volumeMeter3
            // 
            this.volumeMeter3.Amplitude = 0F;
            this.volumeMeter3.Location = new System.Drawing.Point(84, 96);
            this.volumeMeter3.MaxDb = 0F;
            this.volumeMeter3.MinDb = -80F;
            this.volumeMeter3.Name = "volumeMeter3";
            this.volumeMeter3.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter3.TabIndex = 4;
            this.volumeMeter3.Text = "volumeMeter3";
            // 
            // volumeMeter2
            // 
            this.volumeMeter2.Amplitude = 0F;
            this.volumeMeter2.Location = new System.Drawing.Point(68, 96);
            this.volumeMeter2.MaxDb = 0F;
            this.volumeMeter2.MinDb = -80F;
            this.volumeMeter2.Name = "volumeMeter2";
            this.volumeMeter2.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter2.TabIndex = 3;
            this.volumeMeter2.Text = "volumeMeter2";
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.Location = new System.Drawing.Point(53, 96);
            this.volumeMeter1.MaxDb = 0F;
            this.volumeMeter1.MinDb = -80F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(10, 191);
            this.volumeMeter1.TabIndex = 2;
            this.volumeMeter1.Text = "volumeMeter1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // PoweredON
            // 
            this.PoweredON.AutoSize = true;
            this.PoweredON.Location = new System.Drawing.Point(91, 524);
            this.PoweredON.Name = "PoweredON";
            this.PoweredON.Size = new System.Drawing.Size(56, 17);
            this.PoweredON.TabIndex = 3;
            this.PoweredON.Text = "Power";
            this.PoweredON.UseVisualStyleBackColor = true;
            this.PoweredON.CheckedChanged += new System.EventHandler(this.PoweredON_CheckedChanged);
            // 
            // Conected
            // 
            this.Conected.AutoSize = true;
            this.Conected.Location = new System.Drawing.Point(91, 548);
            this.Conected.Name = "Conected";
            this.Conected.Size = new System.Drawing.Size(72, 17);
            this.Conected.TabIndex = 4;
            this.Conected.Text = "Conected";
            this.Conected.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 603);
            this.Controls.Add(this.Conected);
            this.Controls.Add(this.PoweredON);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 642);
            this.MinimumSize = new System.Drawing.Size(815, 642);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox PoweredON;
        private System.Windows.Forms.CheckBox Conected;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.Button SetColorBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private NAudio.Gui.VolumeMeter volumeMeter24;
        private NAudio.Gui.VolumeMeter volumeMeter23;
        private NAudio.Gui.VolumeMeter volumeMeter22;
        private NAudio.Gui.VolumeMeter volumeMeter21;
        private NAudio.Gui.VolumeMeter volumeMeter20;
        private NAudio.Gui.VolumeMeter volumeMeter19;
        private NAudio.Gui.VolumeMeter volumeMeter18;
        private NAudio.Gui.VolumeMeter volumeMeter17;
        private NAudio.Gui.VolumeMeter volumeMeter16;
        private NAudio.Gui.VolumeMeter volumeMeter15;
        private NAudio.Gui.VolumeMeter volumeMeter14;
        private NAudio.Gui.VolumeMeter volumeMeter13;
        private NAudio.Gui.VolumeMeter volumeMeter12;
        private NAudio.Gui.VolumeMeter volumeMeter11;
        private NAudio.Gui.VolumeMeter volumeMeter10;
        private NAudio.Gui.VolumeMeter volumeMeter9;
        private NAudio.Gui.VolumeMeter volumeMeter8;
        private NAudio.Gui.VolumeMeter volumeMeter7;
        private NAudio.Gui.VolumeMeter volumeMeter6;
        private NAudio.Gui.VolumeMeter volumeMeter5;
        private NAudio.Gui.VolumeMeter volumeMeter4;
        private NAudio.Gui.VolumeMeter volumeMeter3;
        private NAudio.Gui.VolumeMeter volumeMeter2;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private NAudio.Gui.Pot pot1;
        private NAudio.Gui.Pot pot2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

