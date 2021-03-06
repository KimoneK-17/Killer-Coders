﻿namespace FleetTrackingInformationSystem
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblFleet = new System.Windows.Forms.Label();
            this.pnlFleet = new System.Windows.Forms.Panel();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.picCargoFleet = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPassReset = new System.Windows.Forms.Button();
            this.chbShow = new System.Windows.Forms.CheckBox();
            this.pnlFleet.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCargoFleet)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUser.Location = new System.Drawing.Point(49, 196);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(109, 28);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPass.Location = new System.Drawing.Point(49, 259);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(102, 28);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(182, 196);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 26);
            this.txtUser.TabIndex = 2;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(23, 29);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(86, 31);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(201, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(370, 29);
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
            this.lblFleet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFleet.Location = new System.Drawing.Point(41, 15);
            this.lblFleet.Name = "lblFleet";
            this.lblFleet.Size = new System.Drawing.Size(398, 33);
            this.lblFleet.TabIndex = 7;
            this.lblFleet.Text = "Fleet Tracking Information System";
            // 
            // pnlFleet
            // 
            this.pnlFleet.BackColor = System.Drawing.Color.Transparent;
            this.pnlFleet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFleet.Controls.Add(this.lblFleet);
            this.pnlFleet.Location = new System.Drawing.Point(28, 46);
            this.pnlFleet.Name = "pnlFleet";
            this.pnlFleet.Size = new System.Drawing.Size(507, 66);
            this.pnlFleet.TabIndex = 8;
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(567, 24);
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
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPass.Location = new System.Drawing.Point(181, 261);
            this.txtPass.MaxLength = 25;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(181, 26);
            this.txtPass.TabIndex = 11;
            // 
            // picCargoFleet
            // 
            this.picCargoFleet.BackColor = System.Drawing.Color.Transparent;
            this.picCargoFleet.Image = ((System.Drawing.Image)(resources.GetObject("picCargoFleet.Image")));
            this.picCargoFleet.Location = new System.Drawing.Point(400, 196);
            this.picCargoFleet.Name = "picCargoFleet";
            this.picCargoFleet.Size = new System.Drawing.Size(123, 96);
            this.picCargoFleet.TabIndex = 13;
            this.picCargoFleet.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnLog);
            this.pnlButtons.Controls.Add(this.btnPassReset);
            this.pnlButtons.Controls.Add(this.btnReg);
            this.pnlButtons.Location = new System.Drawing.Point(28, 375);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(507, 125);
            this.pnlButtons.TabIndex = 14;
            // 
            // btnPassReset
            // 
            this.btnPassReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassReset.Location = new System.Drawing.Point(171, 77);
            this.btnPassReset.Name = "btnPassReset";
            this.btnPassReset.Size = new System.Drawing.Size(144, 31);
            this.btnPassReset.TabIndex = 7;
            this.btnPassReset.Text = "Password Reset";
            this.btnPassReset.UseVisualStyleBackColor = true;
            this.btnPassReset.Click += new System.EventHandler(this.btnPassReset_Click);
            // 
            // chbShow
            // 
            this.chbShow.AutoSize = true;
            this.chbShow.BackColor = System.Drawing.Color.Transparent;
            this.chbShow.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.chbShow.Location = new System.Drawing.Point(222, 306);
            this.chbShow.Name = "chbShow";
            this.chbShow.Size = new System.Drawing.Size(140, 25);
            this.chbShow.TabIndex = 15;
            this.chbShow.Text = "Show Password";
            this.chbShow.UseVisualStyleBackColor = false;
            this.chbShow.CheckedChanged += new System.EventHandler(this.chbShow_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 536);
            this.Controls.Add(this.chbShow);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.picCargoFleet);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pnlFleet);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mnuFleet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuFleet;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Tracking Information System";
            this.pnlFleet.ResumeLayout(false);
            this.pnlFleet.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCargoFleet)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblFleet;
        private System.Windows.Forms.Panel pnlFleet;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox picCargoFleet;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnPassReset;
        private System.Windows.Forms.CheckBox chbShow;
    }
}

