namespace PacmanCOM377
{
    partial class PacmanGUI
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
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.readMapFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pacmanTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.RemainingLivesTextBox = new System.Windows.Forms.TextBox();
            this.ghostTimer = new System.Windows.Forms.Timer(this.components);
            this.StartBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.ghost2Timer = new System.Windows.Forms.Timer(this.components);
            this.muteSound = new System.Windows.Forms.Button();
            this.unmuteSound = new System.Windows.Forms.Button();
            this.colourSel = new System.Windows.Forms.ColorDialog();
            this.backgroundColour = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.livesLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Location = new System.Drawing.Point(1, 0);
            this.mapPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(998, 403);
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mapPictureBox_Paint);
            // 
            // readMapFileDialog
            // 
            this.readMapFileDialog.FileName = "openFileDialog1";
            this.readMapFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.readMapFileDialog_FileOk);
            // 
            // pacmanTimer
            // 
            this.pacmanTimer.Interval = 150;
            this.pacmanTimer.Tick += new System.EventHandler(this.pacmanTimer_Tick);
            // 
            // ScoreBox
            // 
            this.ScoreBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreBox.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.Location = new System.Drawing.Point(27, 435);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(5);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(51, 14);
            this.ScoreBox.TabIndex = 2;
            // 
            // RemainingLivesTextBox
            // 
            this.RemainingLivesTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemainingLivesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RemainingLivesTextBox.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLivesTextBox.Location = new System.Drawing.Point(93, 435);
            this.RemainingLivesTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.RemainingLivesTextBox.Name = "RemainingLivesTextBox";
            this.RemainingLivesTextBox.ReadOnly = true;
            this.RemainingLivesTextBox.Size = new System.Drawing.Size(59, 14);
            this.RemainingLivesTextBox.TabIndex = 3;
            this.RemainingLivesTextBox.Text = "3";
            // 
            // ghostTimer
            // 
            this.ghostTimer.Tick += new System.EventHandler(this.ghostTimer_Tick);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(394, 428);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(64, 29);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.Start_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBtn.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBtn.Location = new System.Drawing.Point(475, 463);
            this.PauseBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(64, 29);
            this.PauseBtn.TabIndex = 5;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.Pause_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ResumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResumeBtn.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeBtn.Location = new System.Drawing.Point(475, 428);
            this.ResumeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(64, 29);
            this.ResumeBtn.TabIndex = 6;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = false;
            this.ResumeBtn.Click += new System.EventHandler(this.Resume_Click);
            // 
            // ghost2Timer
            // 
            this.ghost2Timer.Tick += new System.EventHandler(this.ghost2Timer_Tick);
            // 
            // muteSound
            // 
            this.muteSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.muteSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteSound.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteSound.Location = new System.Drawing.Point(801, 464);
            this.muteSound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.muteSound.Name = "muteSound";
            this.muteSound.Size = new System.Drawing.Size(49, 29);
            this.muteSound.TabIndex = 7;
            this.muteSound.Text = "Mute";
            this.muteSound.UseVisualStyleBackColor = false;
            this.muteSound.Click += new System.EventHandler(this.muteSound_Click_1);
            // 
            // unmuteSound
            // 
            this.unmuteSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.unmuteSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unmuteSound.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unmuteSound.Location = new System.Drawing.Point(854, 463);
            this.unmuteSound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.unmuteSound.Name = "unmuteSound";
            this.unmuteSound.Size = new System.Drawing.Size(52, 29);
            this.unmuteSound.TabIndex = 8;
            this.unmuteSound.Text = "Unmute";
            this.unmuteSound.UseVisualStyleBackColor = false;
            this.unmuteSound.Click += new System.EventHandler(this.unmuteSound_Click);
            // 
            // backgroundColour
            // 
            this.backgroundColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.backgroundColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundColour.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundColour.Location = new System.Drawing.Point(801, 417);
            this.backgroundColour.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backgroundColour.Name = "backgroundColour";
            this.backgroundColour.Size = new System.Drawing.Size(105, 40);
            this.backgroundColour.TabIndex = 9;
            this.backgroundColour.Text = "Background Colour";
            this.backgroundColour.UseVisualStyleBackColor = false;
            this.backgroundColour.Click += new System.EventHandler(this.backgroundColour_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartBtn.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartBtn.Location = new System.Drawing.Point(394, 464);
            this.RestartBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(64, 28);
            this.RestartBtn.TabIndex = 10;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLbl.Location = new System.Drawing.Point(24, 417);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(34, 15);
            this.scoreLbl.TabIndex = 11;
            this.scoreLbl.Text = "Score";
            // 
            // livesLbl
            // 
            this.livesLbl.AutoSize = true;
            this.livesLbl.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.livesLbl.Location = new System.Drawing.Point(90, 417);
            this.livesLbl.Name = "livesLbl";
            this.livesLbl.Size = new System.Drawing.Size(31, 15);
            this.livesLbl.TabIndex = 12;
            this.livesLbl.Text = "Lives";
            // 
            // PacmanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 504);
            this.Controls.Add(this.livesLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.backgroundColour);
            this.Controls.Add(this.unmuteSound);
            this.Controls.Add(this.muteSound);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.RemainingLivesTextBox);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.mapPictureBox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PacmanGUI";
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.PacmanGUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PacmanGUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.OpenFileDialog readMapFileDialog;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.TextBox RemainingLivesTextBox;
        public System.Windows.Forms.Timer pacmanTimer;
        public System.Windows.Forms.Timer ghostTimer;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.Timer ghost2Timer;
        private System.Windows.Forms.Button muteSound;
        private System.Windows.Forms.Button unmuteSound;
        private System.Windows.Forms.ColorDialog colourSel;
        private System.Windows.Forms.Button backgroundColour;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label livesLbl;
    }
}

