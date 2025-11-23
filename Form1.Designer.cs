namespace MusicPlayerT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.grbcn = new System.Windows.Forms.GroupBox();
            this.trackList = new System.Windows.Forms.ListBox();
            this.anhnh = new System.Windows.Forms.PictureBox();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.Volume = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grbtd = new System.Windows.Forms.GroupBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.choinhac = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.volumeLabel = new System.Windows.Forms.Label();
            this.grbcn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.grbtd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choinhac)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(4, 29);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(66, 34);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(4, 77);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(66, 32);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click_1);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(4, 126);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(66, 31);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(4, 176);
            this.previousButton.Margin = new System.Windows.Forms.Padding(2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(66, 31);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(4, 223);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(66, 32);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click_1);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(4, 270);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(66, 32);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.opb_Click);
            // 
            // grbcn
            // 
            this.grbcn.Controls.Add(this.playButton);
            this.grbcn.Controls.Add(this.openButton);
            this.grbcn.Controls.Add(this.pauseButton);
            this.grbcn.Controls.Add(this.stopButton);
            this.grbcn.Controls.Add(this.nextButton);
            this.grbcn.Controls.Add(this.previousButton);
            this.grbcn.Location = new System.Drawing.Point(8, 116);
            this.grbcn.Margin = new System.Windows.Forms.Padding(2);
            this.grbcn.Name = "grbcn";
            this.grbcn.Padding = new System.Windows.Forms.Padding(2);
            this.grbcn.Size = new System.Drawing.Size(85, 315);
            this.grbcn.TabIndex = 6;
            this.grbcn.TabStop = false;
            this.grbcn.Text = "Enjoy";
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.SystemColors.MenuText;
            this.trackList.ForeColor = System.Drawing.SystemColors.Info;
            this.trackList.FormattingEnabled = true;
            this.trackList.Location = new System.Drawing.Point(106, 124);
            this.trackList.Margin = new System.Windows.Forms.Padding(2);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(447, 303);
            this.trackList.TabIndex = 8;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // anhnh
            // 
            this.anhnh.Image = global::MusicPlayerT.Properties.Resources.music_black_vinyl_disc_png_clipart;
            this.anhnh.Location = new System.Drawing.Point(555, 124);
            this.anhnh.Margin = new System.Windows.Forms.Padding(2);
            this.anhnh.Name = "anhnh";
            this.anhnh.Size = new System.Drawing.Size(218, 221);
            this.anhnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhnh.TabIndex = 9;
            this.anhnh.TabStop = false;
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(559, 366);
            this.trackVolume.Margin = new System.Windows.Forms.Padding(2);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(218, 45);
            this.trackVolume.TabIndex = 11;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll_1);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.Location = new System.Drawing.Point(639, 399);
            this.Volume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(69, 20);
            this.Volume.TabIndex = 12;
            this.Volume.Text = "Volume";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.ForeColor = System.Drawing.Color.Lime;
            this.end.Location = new System.Drawing.Point(681, 15);
            this.end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(87, 31);
            this.end.TabIndex = 13;
            this.end.Text = "00:00";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.start.Location = new System.Drawing.Point(4, 15);
            this.start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(87, 31);
            this.start.TabIndex = 14;
            this.start.Text = "00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 89);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(761, 15);
            this.progressBar1.TabIndex = 0;
            // 
            // grbtd
            // 
            this.grbtd.Controls.Add(this.pBar);
            this.grbtd.Controls.Add(this.end);
            this.grbtd.Controls.Add(this.start);
            this.grbtd.Controls.Add(this.choinhac);
            this.grbtd.Controls.Add(this.progressBar1);
            this.grbtd.Location = new System.Drawing.Point(8, 8);
            this.grbtd.Margin = new System.Windows.Forms.Padding(2);
            this.grbtd.Name = "grbtd";
            this.grbtd.Padding = new System.Windows.Forms.Padding(2);
            this.grbtd.Size = new System.Drawing.Size(769, 104);
            this.grbtd.TabIndex = 7;
            this.grbtd.TabStop = false;
            this.grbtd.Text = "Play something!";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(3, 49);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(765, 54);
            this.pBar.TabIndex = 13;
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBar_MouseDown_1);
            // 
            // choinhac
            // 
            this.choinhac.Enabled = true;
            this.choinhac.Location = new System.Drawing.Point(3, 12);
            this.choinhac.Margin = new System.Windows.Forms.Padding(2);
            this.choinhac.Name = "choinhac";
            this.choinhac.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("choinhac.OcxState")));
            this.choinhac.Size = new System.Drawing.Size(765, 88);
            this.choinhac.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(737, 417);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(0, 13);
            this.volumeLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 439);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.anhnh);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.grbtd);
            this.Controls.Add(this.grbcn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.grbcn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anhnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.grbtd.ResumeLayout(false);
            this.grbtd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choinhac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox grbcn;
        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.PictureBox anhnh;
        private AxWMPLib.AxWindowsMediaPlayer choinhac;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grbtd;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label volumeLabel;
    }
}

