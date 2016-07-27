namespace FleetTrackingInformationSystem
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.lblReg = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlReg = new System.Windows.Forms.Panel();
            this.lblPostion = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cboEmpPosition = new System.Windows.Forms.ComboBox();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.picKillerCoders = new System.Windows.Forms.PictureBox();
            this.mnuFleet.SuspendLayout();
            this.pnlReg.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKillerCoders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.Location = new System.Drawing.Point(168, 10);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(193, 42);
            this.lblReg.TabIndex = 0;
            this.lblReg.Text = "Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(43, 213);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(85, 23);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(43, 269);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(117, 23);
            this.lblDateOfBirth.TabIndex = 3;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(213, 265);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(182, 26);
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(213, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(213, 209);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(182, 26);
            this.txtSurname.TabIndex = 6;
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(561, 24);
            this.mnuFleet.TabIndex = 9;
            this.mnuFleet.Text = "menuStrip1";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(99, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(99, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlReg
            // 
            this.pnlReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReg.Controls.Add(this.lblReg);
            this.pnlReg.Location = new System.Drawing.Point(23, 47);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(526, 66);
            this.pnlReg.TabIndex = 10;
            // 
            // lblPostion
            // 
            this.lblPostion.AutoSize = true;
            this.lblPostion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostion.Location = new System.Drawing.Point(43, 328);
            this.lblPostion.Name = "lblPostion";
            this.lblPostion.Size = new System.Drawing.Size(161, 23);
            this.lblPostion.TabIndex = 12;
            this.lblPostion.Text = "Employee Position:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(43, 383);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(96, 23);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(213, 380);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 26);
            this.txtUserName.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(43, 447);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 23);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(213, 444);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(182, 26);
            this.txtPass.TabIndex = 17;
            // 
            // cboEmpPosition
            // 
            this.cboEmpPosition.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpPosition.FormattingEnabled = true;
            this.cboEmpPosition.Location = new System.Drawing.Point(213, 325);
            this.cboEmpPosition.Name = "cboEmpPosition";
            this.cboEmpPosition.Size = new System.Drawing.Size(182, 26);
            this.cboEmpPosition.TabIndex = 38;
            // 
            // pnlBtns
            // 
            this.pnlBtns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtns.Controls.Add(this.button2);
            this.pnlBtns.Controls.Add(this.button1);
            this.pnlBtns.Controls.Add(this.btnSubmit);
            this.pnlBtns.Controls.Add(this.btnReset);
            this.pnlBtns.Location = new System.Drawing.Point(19, 505);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(530, 64);
            this.pnlBtns.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(39, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(292, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 35);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(395, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 35);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picKillerCoders
            // 
            this.picKillerCoders.Image = ((System.Drawing.Image)(resources.GetObject("picKillerCoders.Image")));
            this.picKillerCoders.Location = new System.Drawing.Point(416, 248);
            this.picKillerCoders.Name = "picKillerCoders";
            this.picKillerCoders.Size = new System.Drawing.Size(119, 112);
            this.picKillerCoders.TabIndex = 40;
            this.picKillerCoders.TabStop = false;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 605);
            this.Controls.Add(this.picKillerCoders);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.cboEmpPosition);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPostion);
            this.Controls.Add(this.pnlReg);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mnuFleet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuFleet;
            this.Name = "frmRegistration";
            this.Text = "Fleet Tracking Information System";
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.pnlReg.ResumeLayout(false);
            this.pnlReg.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picKillerCoders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.Panel pnlReg;
        private System.Windows.Forms.Label lblPostion;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cboEmpPosition;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picKillerCoders;
    }
}