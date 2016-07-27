namespace FleetTrackingInformationSystem
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblFleet = new System.Windows.Forms.Label();
            this.pnlFleet = new System.Windows.Forms.Panel();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.MaskedTextBox();
            this.picKillerCoders = new System.Windows.Forms.PictureBox();
            this.pnlFleet.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKillerCoders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(43, 173);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(107, 26);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(43, 281);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 26);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(176, 173);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 26);
            this.txtUser.TabIndex = 2;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(23, 18);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(86, 31);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(199, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 31);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(370, 18);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(86, 31);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblFleet
            // 
            this.lblFleet.AutoSize = true;
            this.lblFleet.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFleet.Location = new System.Drawing.Point(36, 27);
            this.lblFleet.Name = "lblFleet";
            this.lblFleet.Size = new System.Drawing.Size(398, 33);
            this.lblFleet.TabIndex = 7;
            this.lblFleet.Text = "Fleet Tracking information System";
            // 
            // pnlFleet
            // 
            this.pnlFleet.BackColor = System.Drawing.Color.Transparent;
            this.pnlFleet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFleet.Controls.Add(this.lblFleet);
            this.pnlFleet.Location = new System.Drawing.Point(39, 35);
            this.pnlFleet.Name = "pnlFleet";
            this.pnlFleet.Size = new System.Drawing.Size(483, 89);
            this.pnlFleet.TabIndex = 8;
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(541, 24);
            this.mnuFleet.TabIndex = 9;
            this.mnuFleet.Text = "menuStrip1";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBtns
            // 
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtns.Controls.Add(this.btnLog);
            this.pnlBtns.Controls.Add(this.btnReset);
            this.pnlBtns.Controls.Add(this.btnReg);
            this.pnlBtns.Location = new System.Drawing.Point(39, 355);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(483, 56);
            this.pnlBtns.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(176, 281);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 26);
            this.txtPass.TabIndex = 11;
            // 
            // picKillerCoders
            // 
            this.picKillerCoders.Image = ((System.Drawing.Image)(resources.GetObject("picKillerCoders.Image")));
            this.picKillerCoders.Location = new System.Drawing.Point(391, 183);
            this.picKillerCoders.Name = "picKillerCoders";
            this.picKillerCoders.Size = new System.Drawing.Size(119, 112);
            this.picKillerCoders.TabIndex = 12;
            this.picKillerCoders.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(541, 453);
            this.Controls.Add(this.picKillerCoders);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.pnlFleet);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mnuFleet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuFleet;
            this.Name = "frmLogin";
            this.Text = "Fleet Tracking Information System";
            this.pnlFleet.ResumeLayout(false);
            this.pnlFleet.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picKillerCoders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblFleet;
        private System.Windows.Forms.Panel pnlFleet;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.MaskedTextBox txtPass;
        private System.Windows.Forms.PictureBox picKillerCoders;
    }
}

