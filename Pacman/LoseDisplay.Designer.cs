namespace PacmanCOM377
{
    partial class LoseDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoseDisplay));
            this.RestartButton2 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.tryAgain = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tryAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RestartButton2
            // 
            this.RestartButton2.BackColor = System.Drawing.Color.Silver;
            this.RestartButton2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton2.Location = new System.Drawing.Point(157, 348);
            this.RestartButton2.Name = "RestartButton2";
            this.RestartButton2.Size = new System.Drawing.Size(112, 35);
            this.RestartButton2.TabIndex = 1;
            this.RestartButton2.Text = "Restart?";
            this.RestartButton2.UseVisualStyleBackColor = false;
            this.RestartButton2.Click += new System.EventHandler(this.RestartButton2_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Silver;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(360, 348);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(112, 35);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tryAgain
            // 
            this.tryAgain.Image = ((System.Drawing.Image)(resources.GetObject("tryAgain.Image")));
            this.tryAgain.Location = new System.Drawing.Point(238, 101);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(145, 59);
            this.tryAgain.TabIndex = 9;
            this.tryAgain.TabStop = false;
            this.tryAgain.Click += new System.EventHandler(this.tryAgain_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(503, 176);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 105);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoseDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(646, 419);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RestartButton2);
            this.Name = "LoseDisplay";
            this.Text = "Loser";
            ((System.ComponentModel.ISupportInitialize)(this.tryAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RestartButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox tryAgain;
    }
}