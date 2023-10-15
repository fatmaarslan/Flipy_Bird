namespace Flipy_Bird
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
			this.zemin = new System.Windows.Forms.PictureBox();
			this.Boru_üst = new System.Windows.Forms.PictureBox();
			this.Boru_alt = new System.Windows.Forms.PictureBox();
			this.flappybird = new System.Windows.Forms.PictureBox();
			this.score = new System.Windows.Forms.Label();
			this.gametimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Boru_üst)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Boru_alt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
			this.SuspendLayout();
			// 
			// zemin
			// 
			this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
			this.zemin.Location = new System.Drawing.Point(-5, 351);
			this.zemin.Name = "zemin";
			this.zemin.Size = new System.Drawing.Size(626, 50);
			this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.zemin.TabIndex = 0;
			this.zemin.TabStop = false;
			// 
			// Boru_üst
			// 
			this.Boru_üst.Image = ((System.Drawing.Image)(resources.GetObject("Boru_üst.Image")));
			this.Boru_üst.Location = new System.Drawing.Point(474, 3);
			this.Boru_üst.Name = "Boru_üst";
			this.Boru_üst.Size = new System.Drawing.Size(100, 94);
			this.Boru_üst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Boru_üst.TabIndex = 0;
			this.Boru_üst.TabStop = false;
			// 
			// Boru_alt
			// 
			this.Boru_alt.Image = ((System.Drawing.Image)(resources.GetObject("Boru_alt.Image")));
			this.Boru_alt.Location = new System.Drawing.Point(430, 287);
			this.Boru_alt.Name = "Boru_alt";
			this.Boru_alt.Size = new System.Drawing.Size(100, 71);
			this.Boru_alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Boru_alt.TabIndex = 0;
			this.Boru_alt.TabStop = false;
			// 
			// flappybird
			// 
			this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
			this.flappybird.Location = new System.Drawing.Point(147, 137);
			this.flappybird.Name = "flappybird";
			this.flappybird.Size = new System.Drawing.Size(100, 64);
			this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.flappybird.TabIndex = 0;
			this.flappybird.TabStop = false;
			// 
			// score
			// 
			this.score.AutoSize = true;
			this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.score.Location = new System.Drawing.Point(93, 422);
			this.score.Name = "score";
			this.score.Size = new System.Drawing.Size(99, 29);
			this.score.TabIndex = 1;
			this.score.Text = "score:0";
			
			// gametimer
			// 
			this.gametimer.Enabled = true;
			this.gametimer.Interval = 20;
			this.gametimer.Tick += new System.EventHandler(this.gametimerEvents);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(621, 450);
			this.Controls.Add(this.flappybird);
			this.Controls.Add(this.score);
			this.Controls.Add(this.Boru_üst);
			this.Controls.Add(this.zemin);
			this.Controls.Add(this.Boru_alt);
			this.Name = "Form1";
			this.Text = "Flipy_Bird";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
			((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Boru_üst)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Boru_alt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox Boru_üst;
        private System.Windows.Forms.PictureBox Boru_alt;
        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer gametimer;
    }
}

