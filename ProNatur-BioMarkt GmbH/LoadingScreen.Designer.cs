namespace ProNatur_BioMarkt_GmbH
{
    partial class LoadingScreen
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
            this.loadingProgressbar = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblLoadingBarProgress = new System.Windows.Forms.Label();
            this.loadingbarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingProgressbar
            // 
            this.loadingProgressbar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.loadingProgressbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadingProgressbar.Location = new System.Drawing.Point(12, 299);
            this.loadingProgressbar.Name = "loadingProgressbar";
            this.loadingProgressbar.Size = new System.Drawing.Size(752, 23);
            this.loadingProgressbar.TabIndex = 0;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(353, 283);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(45, 13);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading";
            // 
            // lblLoadingBarProgress
            // 
            this.lblLoadingBarProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLoadingBarProgress.AutoSize = true;
            this.lblLoadingBarProgress.ForeColor = System.Drawing.Color.White;
            this.lblLoadingBarProgress.Location = new System.Drawing.Point(404, 283);
            this.lblLoadingBarProgress.Name = "lblLoadingBarProgress";
            this.lblLoadingBarProgress.Size = new System.Drawing.Size(21, 13);
            this.lblLoadingBarProgress.TabIndex = 2;
            this.lblLoadingBarProgress.Text = "0%";
            // 
            // loadingbarTimer
            // 
            this.loadingbarTimer.Interval = 25;
            this.loadingbarTimer.Tick += new System.EventHandler(this.loadingbarTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ProNatur_BioMarkt_GmbH.Properties.Resources.GroceryImg;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 345);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(776, 334);
            this.Controls.Add(this.lblLoadingBarProgress);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.loadingProgressbar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProNatur-Biomarkt GmbH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingScreen_FormClosed);
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingProgressbar;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblLoadingBarProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer loadingbarTimer;
    }
}

