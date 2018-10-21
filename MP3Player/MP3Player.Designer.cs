namespace MP3Player
{
    partial class MP3Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3Player));
            this.PlayBT = new System.Windows.Forms.Button();
            this.chooseSongBT = new System.Windows.Forms.Button();
            this.songTitleTxt = new System.Windows.Forms.TextBox();
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.volumeTimer = new System.Windows.Forms.Timer(this.components);
            this.volumeCounter = new System.Windows.Forms.Label();
            this.songTimeLbl = new System.Windows.Forms.Label();
            this.songTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.playlistCB = new System.Windows.Forms.CheckBox();
            this.playListPathTxt = new System.Windows.Forms.TextBox();
            this.helpTx = new System.Windows.Forms.TextBox();
            this.confirmBT = new System.Windows.Forms.Button();
            this.prevSong = new System.Windows.Forms.Button();
            this.nextSong = new System.Windows.Forms.Button();
            this.PauseBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayBT
            // 
            this.PlayBT.BackColor = System.Drawing.Color.Orange;
            this.PlayBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayBT.Enabled = false;
            this.PlayBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PlayBT.FlatAppearance.BorderSize = 0;
            this.PlayBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayBT.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBT.Location = new System.Drawing.Point(12, 12);
            this.PlayBT.Name = "PlayBT";
            this.PlayBT.Size = new System.Drawing.Size(101, 69);
            this.PlayBT.TabIndex = 0;
            this.PlayBT.Text = "PLAY";
            this.PlayBT.UseVisualStyleBackColor = false;
            this.PlayBT.Click += new System.EventHandler(this.PlayBT_Click);
            // 
            // chooseSongBT
            // 
            this.chooseSongBT.BackColor = System.Drawing.Color.Silver;
            this.chooseSongBT.FlatAppearance.BorderSize = 0;
            this.chooseSongBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseSongBT.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseSongBT.Location = new System.Drawing.Point(119, 12);
            this.chooseSongBT.Name = "chooseSongBT";
            this.chooseSongBT.Size = new System.Drawing.Size(160, 69);
            this.chooseSongBT.TabIndex = 1;
            this.chooseSongBT.Text = "Choose your song";
            this.chooseSongBT.UseVisualStyleBackColor = false;
            this.chooseSongBT.Click += new System.EventHandler(this.chooseSongBT_Click);
            this.chooseSongBT.MouseEnter += new System.EventHandler(this.chooseSongBT_MouseEnter);
            // 
            // songTitleTxt
            // 
            this.songTitleTxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.songTitleTxt.Location = new System.Drawing.Point(12, 175);
            this.songTitleTxt.Name = "songTitleTxt";
            this.songTitleTxt.ReadOnly = true;
            this.songTitleTxt.Size = new System.Drawing.Size(267, 23);
            this.songTitleTxt.TabIndex = 2;
            this.songTitleTxt.Text = "Song title";
            this.songTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(11, 205);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(268, 10);
            this.timeBar.TabIndex = 3;
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(11, 228);
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(230, 45);
            this.volumeSlider.TabIndex = 5;
            this.volumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeSlider.Value = 5;
            this.volumeSlider.MouseEnter += new System.EventHandler(this.volumeSlider_MouseEnter);
            // 
            // volumeTimer
            // 
            this.volumeTimer.Tick += new System.EventHandler(this.volumeTimer_Tick);
            // 
            // volumeCounter
            // 
            this.volumeCounter.AutoSize = true;
            this.volumeCounter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volumeCounter.Location = new System.Drawing.Point(242, 228);
            this.volumeCounter.Name = "volumeCounter";
            this.volumeCounter.Size = new System.Drawing.Size(29, 19);
            this.volumeCounter.TabIndex = 6;
            this.volumeCounter.Text = "5%";
            this.volumeCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // songTimeLbl
            // 
            this.songTimeLbl.AutoSize = true;
            this.songTimeLbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.songTimeLbl.Location = new System.Drawing.Point(128, 102);
            this.songTimeLbl.Name = "songTimeLbl";
            this.songTimeLbl.Size = new System.Drawing.Size(134, 59);
            this.songTimeLbl.TabIndex = 7;
            this.songTimeLbl.Text = "00:00";
            // 
            // songTimeTimer
            // 
            this.songTimeTimer.Interval = 1000;
            this.songTimeTimer.Tick += new System.EventHandler(this.songTimeTimer_Tick);
            // 
            // playlistCB
            // 
            this.playlistCB.AutoSize = true;
            this.playlistCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playlistCB.Location = new System.Drawing.Point(11, 269);
            this.playlistCB.Name = "playlistCB";
            this.playlistCB.Size = new System.Drawing.Size(140, 23);
            this.playlistCB.TabIndex = 8;
            this.playlistCB.Text = "Use Your playlist";
            this.playlistCB.UseVisualStyleBackColor = true;
            this.playlistCB.CheckedChanged += new System.EventHandler(this.playlistCB_CheckedChanged);
            // 
            // playListPathTxt
            // 
            this.playListPathTxt.BackColor = System.Drawing.SystemColors.Control;
            this.playListPathTxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playListPathTxt.Location = new System.Drawing.Point(11, 298);
            this.playListPathTxt.Name = "playListPathTxt";
            this.playListPathTxt.Size = new System.Drawing.Size(192, 23);
            this.playListPathTxt.TabIndex = 9;
            this.playListPathTxt.Text = "C:\\Muzyka\\";
            this.playListPathTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playListPathTxt.Visible = false;
            this.playListPathTxt.MouseEnter += new System.EventHandler(this.playListPathTxt_MouseEnter);
            // 
            // helpTx
            // 
            this.helpTx.BackColor = System.Drawing.Color.Gray;
            this.helpTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpTx.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpTx.Location = new System.Drawing.Point(12, 371);
            this.helpTx.Name = "helpTx";
            this.helpTx.Size = new System.Drawing.Size(267, 15);
            this.helpTx.TabIndex = 11;
            this.helpTx.Text = "Help";
            this.helpTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.helpTx.Visible = false;
            // 
            // confirmBT
            // 
            this.confirmBT.BackColor = System.Drawing.SystemColors.Control;
            this.confirmBT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmBT.Location = new System.Drawing.Point(209, 298);
            this.confirmBT.Name = "confirmBT";
            this.confirmBT.Size = new System.Drawing.Size(70, 23);
            this.confirmBT.TabIndex = 12;
            this.confirmBT.Text = "confirm";
            this.confirmBT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmBT.UseVisualStyleBackColor = false;
            this.confirmBT.Visible = false;
            this.confirmBT.Click += new System.EventHandler(this.confirmBT_Click);
            this.confirmBT.MouseEnter += new System.EventHandler(this.confirmBT_MouseEnter);
            // 
            // prevSong
            // 
            this.prevSong.Enabled = false;
            this.prevSong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevSong.Location = new System.Drawing.Point(11, 327);
            this.prevSong.Name = "prevSong";
            this.prevSong.Size = new System.Drawing.Size(127, 23);
            this.prevSong.TabIndex = 13;
            this.prevSong.Text = "<<";
            this.prevSong.UseVisualStyleBackColor = true;
            this.prevSong.Visible = false;
            this.prevSong.Click += new System.EventHandler(this.prevSong_Click);
            this.prevSong.MouseEnter += new System.EventHandler(this.prevSong_MouseEnter);
            // 
            // nextSong
            // 
            this.nextSong.Enabled = false;
            this.nextSong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextSong.Location = new System.Drawing.Point(154, 327);
            this.nextSong.Name = "nextSong";
            this.nextSong.Size = new System.Drawing.Size(125, 23);
            this.nextSong.TabIndex = 14;
            this.nextSong.Text = ">>";
            this.nextSong.UseVisualStyleBackColor = true;
            this.nextSong.Visible = false;
            this.nextSong.Click += new System.EventHandler(this.nextSong_Click);
            this.nextSong.MouseEnter += new System.EventHandler(this.nextSong_MouseEnter);
            // 
            // PauseBT
            // 
            this.PauseBT.BackColor = System.Drawing.Color.Orange;
            this.PauseBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PauseBT.Enabled = false;
            this.PauseBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PauseBT.FlatAppearance.BorderSize = 0;
            this.PauseBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PauseBT.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBT.Location = new System.Drawing.Point(11, 95);
            this.PauseBT.Name = "PauseBT";
            this.PauseBT.Size = new System.Drawing.Size(101, 69);
            this.PauseBT.TabIndex = 15;
            this.PauseBT.Text = "PAUSE";
            this.PauseBT.UseVisualStyleBackColor = false;
            this.PauseBT.Click += new System.EventHandler(this.PauseBT_Click);
            // 
            // MP3Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(291, 387);
            this.Controls.Add(this.PauseBT);
            this.Controls.Add(this.nextSong);
            this.Controls.Add(this.prevSong);
            this.Controls.Add(this.confirmBT);
            this.Controls.Add(this.helpTx);
            this.Controls.Add(this.playListPathTxt);
            this.Controls.Add(this.playlistCB);
            this.Controls.Add(this.songTimeLbl);
            this.Controls.Add(this.volumeCounter);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.songTitleTxt);
            this.Controls.Add(this.chooseSongBT);
            this.Controls.Add(this.PlayBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MP3Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 Player";
            this.MouseEnter += new System.EventHandler(this.MP3Player_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayBT;
        private System.Windows.Forms.Button chooseSongBT;
        private System.Windows.Forms.TextBox songTitleTxt;
        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.Timer volumeTimer;
        private System.Windows.Forms.Label volumeCounter;
        private System.Windows.Forms.Label songTimeLbl;
        private System.Windows.Forms.Timer songTimeTimer;
        private System.Windows.Forms.CheckBox playlistCB;
        private System.Windows.Forms.TextBox playListPathTxt;
        private System.Windows.Forms.TextBox helpTx;
        private System.Windows.Forms.Button confirmBT;
        private System.Windows.Forms.Button prevSong;
        private System.Windows.Forms.Button nextSong;
        private System.Windows.Forms.Button PauseBT;
    }
}

