namespace PacmanCOM377
{
    partial class WinDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinDisplay));
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.replayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.winTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Silver;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(347, 336);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(112, 35);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // replayButton
            // 
            this.replayButton.BackColor = System.Drawing.Color.Silver;
            this.replayButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.ForeColor = System.Drawing.Color.Black;
            this.replayButton.Location = new System.Drawing.Point(190, 336);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(120, 35);
            this.replayButton.TabIndex = 7;
            this.replayButton.Text = "Replay!";
            this.replayButton.UseVisualStyleBackColor = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 103);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // winTxt
            // 
            this.winTxt.AutoSize = true;
            this.winTxt.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winTxt.Location = new System.Drawing.Point(191, 166);
            this.winTxt.Name = "winTxt";
            this.winTxt.Size = new System.Drawing.Size(257, 80);
            this.winTxt.TabIndex = 9;
            this.winTxt.Text = "You Win!";
            // 
            // WinDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(646, 419);
            this.Controls.Add(this.winTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Name = "WinDisplay";
            this.Text = "Winner!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label winTxt;
    }
}