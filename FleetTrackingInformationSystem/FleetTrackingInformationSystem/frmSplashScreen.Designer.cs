namespace FleetTrackingInformationSystem
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.picCargoFleet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCargoFleet)).BeginInit();
            this.SuspendLayout();
            // 
            // picCargoFleet
            // 
            this.picCargoFleet.BackColor = System.Drawing.Color.Transparent;
            this.picCargoFleet.Image = ((System.Drawing.Image)(resources.GetObject("picCargoFleet.Image")));
            this.picCargoFleet.Location = new System.Drawing.Point(25, 552);
            this.picCargoFleet.Name = "picCargoFleet";
            this.picCargoFleet.Size = new System.Drawing.Size(247, 172);
            this.picCargoFleet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCargoFleet.TabIndex = 14;
            this.picCargoFleet.TabStop = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(661, 785);
            this.Controls.Add(this.picCargoFleet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Tracking Information System";
            ((System.ComponentModel.ISupportInitialize)(this.picCargoFleet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCargoFleet;
    }
}