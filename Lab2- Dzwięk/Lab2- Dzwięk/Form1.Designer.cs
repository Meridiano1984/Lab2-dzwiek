namespace Lab2__Dzwięk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Select = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.SoundPlay = new System.Windows.Forms.RadioButton();
            this.Wave = new System.Windows.Forms.RadioButton();
            this.DirectSound = new System.Windows.Forms.RadioButton();
            this.listBoxMicrophones = new System.Windows.Forms.ListBox();
            this.FindMic = new System.Windows.Forms.Button();
            this.SelectFile = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.Button();
            this.Slow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Select
            // 
            this.Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Select.Location = new System.Drawing.Point(53, 35);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(135, 54);
            this.Select.TabIndex = 0;
            this.Select.Text = "SELECT";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.button1_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(53, 107);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(135, 51);
            this.Play.TabIndex = 1;
            this.Play.Text = "PLAY";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // SoundPlay
            // 
            this.SoundPlay.AutoSize = true;
            this.SoundPlay.Location = new System.Drawing.Point(59, 186);
            this.SoundPlay.Name = "SoundPlay";
            this.SoundPlay.Size = new System.Drawing.Size(116, 24);
            this.SoundPlay.TabIndex = 2;
            this.SoundPlay.TabStop = true;
            this.SoundPlay.Text = "Sound Player";
            this.SoundPlay.UseVisualStyleBackColor = true;
            // 
            // Wave
            // 
            this.Wave.AutoSize = true;
            this.Wave.Location = new System.Drawing.Point(59, 216);
            this.Wave.Name = "Wave";
            this.Wave.Size = new System.Drawing.Size(90, 24);
            this.Wave.TabIndex = 3;
            this.Wave.TabStop = true;
            this.Wave.Text = "WaveOut";
            this.Wave.UseVisualStyleBackColor = true;
            // 
            // DirectSound
            // 
            this.DirectSound.AutoSize = true;
            this.DirectSound.Location = new System.Drawing.Point(59, 246);
            this.DirectSound.Name = "DirectSound";
            this.DirectSound.Size = new System.Drawing.Size(116, 24);
            this.DirectSound.TabIndex = 4;
            this.DirectSound.TabStop = true;
            this.DirectSound.Text = "Direct Sound";
            this.DirectSound.UseVisualStyleBackColor = true;
            // 
            // listBoxMicrophones
            // 
            this.listBoxMicrophones.FormattingEnabled = true;
            this.listBoxMicrophones.ItemHeight = 20;
            this.listBoxMicrophones.Location = new System.Drawing.Point(657, 35);
            this.listBoxMicrophones.Name = "listBoxMicrophones";
            this.listBoxMicrophones.Size = new System.Drawing.Size(269, 84);
            this.listBoxMicrophones.TabIndex = 5;
            // 
            // FindMic
            // 
            this.FindMic.Location = new System.Drawing.Point(470, 37);
            this.FindMic.Name = "FindMic";
            this.FindMic.Size = new System.Drawing.Size(119, 50);
            this.FindMic.TabIndex = 6;
            this.FindMic.Text = "Find Mic";
            this.FindMic.UseVisualStyleBackColor = true;
            this.FindMic.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(470, 107);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(119, 51);
            this.SelectFile.TabIndex = 7;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(470, 172);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(119, 48);
            this.Record.TabIndex = 8;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Slow
            // 
            this.Slow.Location = new System.Drawing.Point(53, 296);
            this.Slow.Name = "Slow";
            this.Slow.Size = new System.Drawing.Size(123, 47);
            this.Slow.TabIndex = 9;
            this.Slow.Text = "Play Slowed";
            this.Slow.UseVisualStyleBackColor = true;
            this.Slow.Click += new System.EventHandler(this.Slow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 381);
            this.Controls.Add(this.Slow);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.FindMic);
            this.Controls.Add(this.listBoxMicrophones);
            this.Controls.Add(this.DirectSound);
            this.Controls.Add(this.Wave);
            this.Controls.Add(this.SoundPlay);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Select;
        private Button Play;
        private RadioButton SoundPlay;
        private RadioButton Wave;
        private RadioButton DirectSound;
        private ListBox listBoxMicrophones;
        private Button FindMic;
        private Button SelectFile;
        private Button Record;
        private Button Slow;
    }
}