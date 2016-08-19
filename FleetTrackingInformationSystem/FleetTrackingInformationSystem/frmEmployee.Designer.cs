namespace FleetTrackingInformationSystem
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.updHours = new System.Windows.Forms.NumericUpDown();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlEmployee.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHours)).BeginInit();
            this.pnlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEmployee.Controls.Add(this.lblEmployee);
            this.pnlEmployee.Location = new System.Drawing.Point(33, 60);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(507, 100);
            this.pnlEmployee.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(177, 26);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(148, 39);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(585, 24);
            this.mnuFleet.TabIndex = 13;
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(50, 194);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 19);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Employee Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(50, 240);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(145, 19);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Employee Surname:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(50, 286);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(98, 19);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "Employee ID:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(50, 338);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(139, 19);
            this.lblPosition.TabIndex = 20;
            this.lblPosition.Text = "Employee Position:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(50, 388);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(138, 19);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Employee Address:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContactNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNum.Location = new System.Drawing.Point(50, 430);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(126, 19);
            this.lblContactNum.TabIndex = 22;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 475);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 19);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHours.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(50, 521);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(111, 19);
            this.lblHours.TabIndex = 24;
            this.lblHours.Text = "Hours Worked:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(50, 569);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(114, 19);
            this.lblSalary.TabIndex = 25;
            this.lblSalary.Text = "Monthly Salary";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(246, 187);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 26);
            this.txtName.TabIndex = 26;
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(246, 233);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(234, 26);
            this.txtSurname.TabIndex = 27;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(246, 279);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 26);
            this.txtID.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(246, 381);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 26);
            this.txtAddress.TabIndex = 30;
            // 
            // txtContactNum
            // 
            this.txtContactNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNum.Location = new System.Drawing.Point(246, 423);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(234, 26);
            this.txtContactNum.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(246, 468);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 26);
            this.txtEmail.TabIndex = 32;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(246, 562);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(234, 26);
            this.txtSalary.TabIndex = 34;
            // 
            // updHours
            // 
            this.updHours.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updHours.Location = new System.Drawing.Point(246, 514);
            this.updHours.Name = "updHours";
            this.updHours.Size = new System.Drawing.Size(234, 26);
            this.updHours.TabIndex = 35;
            // 
            // cboPosition
            // 
            this.cboPosition.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(246, 331);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(234, 26);
            this.cboPosition.TabIndex = 36;
            // 
            // pnlBtns
            // 
            this.pnlBtns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtns.Controls.Add(this.btnSearch);
            this.pnlBtns.Controls.Add(this.btnDelete);
            this.pnlBtns.Controls.Add(this.btnSubmit);
            this.pnlBtns.Controls.Add(this.btnReset);
            this.pnlBtns.Location = new System.Drawing.Point(33, 624);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(507, 64);
            this.pnlBtns.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(19, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 35);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(122, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 722);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.updHours);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.Text = "Fleet Tracking Information System";
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHours)).EndInit();
            this.pnlBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.NumericUpDown updHours;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
    }
}