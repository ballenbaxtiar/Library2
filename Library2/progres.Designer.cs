namespace Library2
{
    partial class progres
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progress = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.label5.Font = new System.Drawing.Font("NRT Reg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(82)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(3, 500);
            this.label5.TabIndex = 251;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.label4.Font = new System.Drawing.Font("NRT Reg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(82)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(-112, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(731, 3);
            this.label4.TabIndex = 250;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.label10.Font = new System.Drawing.Font("NRT Reg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(82)))), ((int)(((byte)(149)))));
            this.label10.Location = new System.Drawing.Point(504, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(3, 500);
            this.label10.TabIndex = 249;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(77)))), ((int)(((byte)(104)))));
            this.label7.Font = new System.Drawing.Font("NRT Reg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(82)))), ((int)(((byte)(149)))));
            this.label7.Location = new System.Drawing.Point(-222, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(731, 3);
            this.label7.TabIndex = 248;
            // 
            // progress
            // 
            this.progress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress.AnimationSpeed = 500;
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(192)))));
            this.progress.InnerColor = System.Drawing.SystemColors.Window;
            this.progress.InnerMargin = 2;
            this.progress.InnerWidth = -1;
            this.progress.Location = new System.Drawing.Point(5, 6);
            this.progress.MarqueeAnimationSpeed = 2000;
            this.progress.Name = "progress";
            this.progress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.progress.OuterMargin = -25;
            this.progress.OuterWidth = 0;
            this.progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.progress.ProgressWidth = 20;
            this.progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress.Size = new System.Drawing.Size(493, 488);
            this.progress.StartAngle = 270;
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.SubscriptColor = System.Drawing.Color.Red;
            this.progress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress.SubscriptText = "";
            this.progress.SuperscriptColor = System.Drawing.Color.IndianRed;
            this.progress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress.SuperscriptText = "";
            this.progress.TabIndex = 252;
            this.progress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progress.UseWaitCursor = true;
            this.progress.Value = 68;
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(93, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 69);
            this.label1.TabIndex = 253;
            this.label1.Text = "Pleas wait!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "progres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "progres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private CircularProgressBar.CircularProgressBar progress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}