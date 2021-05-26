
namespace Game3
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.downWall = new System.Windows.Forms.PictureBox();
            this.upperWall = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperWall)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 565);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Ground";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Yellow;
            this.bird.Location = new System.Drawing.Point(30, 165);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(40, 40);
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // downWall
            // 
            this.downWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.downWall.Location = new System.Drawing.Point(420, 350);
            this.downWall.Name = "downWall";
            this.downWall.Size = new System.Drawing.Size(70, 1000);
            this.downWall.TabIndex = 2;
            this.downWall.TabStop = false;
            this.downWall.Tag = "wall";
            // 
            // upperWall
            // 
            this.upperWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.upperWall.Location = new System.Drawing.Point(420, -850);
            this.upperWall.Name = "upperWall";
            this.upperWall.Size = new System.Drawing.Size(70, 1000);
            this.upperWall.TabIndex = 3;
            this.upperWall.TabStop = false;
            this.upperWall.Tag = "wall";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(13, 13);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(62, 18);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "score:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(584, 591);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.upperWall);
            this.Controls.Add(this.downWall);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox downWall;
        private System.Windows.Forms.PictureBox upperWall;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer timer1;
    }
}

