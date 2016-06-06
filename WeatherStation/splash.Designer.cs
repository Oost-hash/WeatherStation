namespace WeatherStation
{
    partial class splash
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
            this.splashLbltitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.splashProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // splashLbltitle
            // 
            this.splashLbltitle.AutoSize = true;
            this.splashLbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashLbltitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.splashLbltitle.Location = new System.Drawing.Point(71, 91);
            this.splashLbltitle.Name = "splashLbltitle";
            this.splashLbltitle.Size = new System.Drawing.Size(177, 29);
            this.splashLbltitle.TabIndex = 0;
            this.splashLbltitle.Text = "WeatherStation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(136, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "v0.1";
            // 
            // splashTimer
            // 
            this.splashTimer.Enabled = true;
            this.splashTimer.Interval = 32;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // splashProgress
            // 
            this.splashProgress.Location = new System.Drawing.Point(101, 123);
            this.splashProgress.Name = "splashProgress";
            this.splashProgress.Size = new System.Drawing.Size(100, 23);
            this.splashProgress.TabIndex = 2;
            this.splashProgress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 227);
            this.Controls.Add(this.splashProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splashLbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label splashLbltitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.ProgressBar splashProgress;
    }
}