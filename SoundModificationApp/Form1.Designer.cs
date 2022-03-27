namespace SoundModificationApp
{
    partial class MainForm
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
            this.BtnStartAndStopSound = new System.Windows.Forms.Button();
            this.TracBarPitchInput = new System.Windows.Forms.TrackBar();
            this.CmbBoxInputDevice = new System.Windows.Forms.ComboBox();
            this.CmbBoxOutputDevice = new System.Windows.Forms.ComboBox();
            this.gupBxWaveViewers = new System.Windows.Forms.GroupBox();
            this.WavViewUnmodeOutput = new NAudio.Gui.WaveViewer();
            this.WavViewModedOutput = new NAudio.Gui.WaveViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TracBarPitchInput)).BeginInit();
            this.gupBxWaveViewers.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStartAndStopSound
            // 
            this.BtnStartAndStopSound.Location = new System.Drawing.Point(649, 366);
            this.BtnStartAndStopSound.Name = "BtnStartAndStopSound";
            this.BtnStartAndStopSound.Size = new System.Drawing.Size(137, 52);
            this.BtnStartAndStopSound.TabIndex = 0;
            this.BtnStartAndStopSound.Text = "Start Sound Capture";
            this.BtnStartAndStopSound.UseVisualStyleBackColor = true;
            this.BtnStartAndStopSound.Click += new System.EventHandler(this.BtnStartAndStopSound_Click);
            // 
            // TracBarPitchInput
            // 
            this.TracBarPitchInput.Location = new System.Drawing.Point(12, 373);
            this.TracBarPitchInput.Minimum = -10;
            this.TracBarPitchInput.Name = "TracBarPitchInput";
            this.TracBarPitchInput.Size = new System.Drawing.Size(614, 45);
            this.TracBarPitchInput.TabIndex = 1;
            this.TracBarPitchInput.Scroll += new System.EventHandler(this.TracBarPitchInput_Scroll);
            this.TracBarPitchInput.ValueChanged += new System.EventHandler(this.TracBarPitchInput_Scroll);
            // 
            // CmbBoxInputDevice
            // 
            this.CmbBoxInputDevice.FormattingEnabled = true;
            this.CmbBoxInputDevice.Location = new System.Drawing.Point(16, 18);
            this.CmbBoxInputDevice.Name = "CmbBoxInputDevice";
            this.CmbBoxInputDevice.Size = new System.Drawing.Size(172, 21);
            this.CmbBoxInputDevice.TabIndex = 2;
            // 
            // CmbBoxOutputDevice
            // 
            this.CmbBoxOutputDevice.FormattingEnabled = true;
            this.CmbBoxOutputDevice.Location = new System.Drawing.Point(231, 18);
            this.CmbBoxOutputDevice.Name = "CmbBoxOutputDevice";
            this.CmbBoxOutputDevice.Size = new System.Drawing.Size(172, 21);
            this.CmbBoxOutputDevice.TabIndex = 3;
            // 
            // gupBxWaveViewers
            // 
            this.gupBxWaveViewers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gupBxWaveViewers.Controls.Add(this.WavViewUnmodeOutput);
            this.gupBxWaveViewers.Controls.Add(this.WavViewModedOutput);
            this.gupBxWaveViewers.Location = new System.Drawing.Point(12, 45);
            this.gupBxWaveViewers.Name = "gupBxWaveViewers";
            this.gupBxWaveViewers.Size = new System.Drawing.Size(745, 315);
            this.gupBxWaveViewers.TabIndex = 4;
            this.gupBxWaveViewers.TabStop = false;
            // 
            // WavViewUnmodeOutput
            // 
            this.WavViewUnmodeOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WavViewUnmodeOutput.Location = new System.Drawing.Point(6, 19);
            this.WavViewUnmodeOutput.Name = "WavViewUnmodeOutput";
            this.WavViewUnmodeOutput.SamplesPerPixel = 6;
            this.WavViewUnmodeOutput.Size = new System.Drawing.Size(733, 129);
            this.WavViewUnmodeOutput.StartPosition = ((long)(0));
            this.WavViewUnmodeOutput.TabIndex = 3;
            this.WavViewUnmodeOutput.WaveStream = null;
            // 
            // WavViewModedOutput
            // 
            this.WavViewModedOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WavViewModedOutput.Location = new System.Drawing.Point(6, 171);
            this.WavViewModedOutput.Name = "WavViewModedOutput";
            this.WavViewModedOutput.SamplesPerPixel = 6;
            this.WavViewModedOutput.Size = new System.Drawing.Size(733, 138);
            this.WavViewModedOutput.StartPosition = ((long)(0));
            this.WavViewModedOutput.TabIndex = 2;
            this.WavViewModedOutput.WaveStream = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gupBxWaveViewers);
            this.Controls.Add(this.CmbBoxOutputDevice);
            this.Controls.Add(this.CmbBoxInputDevice);
            this.Controls.Add(this.TracBarPitchInput);
            this.Controls.Add(this.BtnStartAndStopSound);
            this.Name = "MainForm";
            this.Text = "Sound Modify";
            ((System.ComponentModel.ISupportInitialize)(this.TracBarPitchInput)).EndInit();
            this.gupBxWaveViewers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartAndStopSound;
        private System.Windows.Forms.TrackBar TracBarPitchInput;
        private System.Windows.Forms.ComboBox CmbBoxInputDevice;
        private System.Windows.Forms.ComboBox CmbBoxOutputDevice;
        private System.Windows.Forms.GroupBox gupBxWaveViewers;
        private NAudio.Gui.WaveViewer WavViewModedOutput;
        private NAudio.Gui.WaveViewer WavViewUnmodeOutput;
    }
}

