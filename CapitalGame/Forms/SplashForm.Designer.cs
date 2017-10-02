namespace CapitalGame.Forms
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.Version = new System.Windows.Forms.Label();
            this.SplashImage = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SplashTmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Version.Location = new System.Drawing.Point(400, 245);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(0, 13);
            this.Version.TabIndex = 0;
            // 
            // SplashImage
            // 
            this.SplashImage.Image = global::CapitalGame.Properties.Resources.unitedStatesMap;
            this.SplashImage.Location = new System.Drawing.Point(3, 9);
            this.SplashImage.Name = "SplashImage";
            this.SplashImage.Size = new System.Drawing.Size(459, 308);
            this.SplashImage.TabIndex = 1;
            this.SplashImage.TabStop = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleLbl.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(82, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(318, 27);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "The State Capital Game";
            // 
            // SplashTmr
            // 
            this.SplashTmr.Enabled = true;
            this.SplashTmr.Interval = 3500;
            this.SplashTmr.Tick += new System.EventHandler(this.SplashTmr_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(464, 314);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.SplashImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Capital Matching Game";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.PictureBox SplashImage;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Timer SplashTmr;
    }
}