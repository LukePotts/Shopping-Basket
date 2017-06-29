namespace QA
{
    partial class ShoppingBasketSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingBasketSplashScreen));
            this.Title = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.SplashProgress = new System.Windows.Forms.ProgressBar();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(12, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(344, 48);
            this.Title.TabIndex = 0;
            this.Title.Text = "Shopping Basket";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subtitle
            // 
            this.Subtitle.BackColor = System.Drawing.Color.Transparent;
            this.Subtitle.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Subtitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.ForeColor = System.Drawing.Color.White;
            this.Subtitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Subtitle.Location = new System.Drawing.Point(12, 319);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(344, 42);
            this.Subtitle.TabIndex = 1;
            this.Subtitle.Text = "Luke Potts - Apprenticeship Coursework  - 2017";
            this.Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashProgress
            // 
            this.SplashProgress.BackColor = System.Drawing.Color.Black;
            this.SplashProgress.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.SplashProgress.ForeColor = System.Drawing.Color.White;
            this.SplashProgress.Location = new System.Drawing.Point(12, 375);
            this.SplashProgress.Name = "SplashProgress";
            this.SplashProgress.Size = new System.Drawing.Size(344, 23);
            this.SplashProgress.TabIndex = 2;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // ShoppingBasketSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(368, 410);
            this.Controls.Add(this.SplashProgress);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShoppingBasketSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingBasketSplashScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.ProgressBar SplashProgress;
        private System.Windows.Forms.Timer SplashTimer;
    }
}