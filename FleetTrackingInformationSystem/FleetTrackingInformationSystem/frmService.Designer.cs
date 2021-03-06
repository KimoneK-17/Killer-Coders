﻿namespace FleetTrackingInformationSystem
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblVehicleRegNumber = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.pnlService = new System.Windows.Forms.Panel();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.cboAppointTime = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppointDescription = new System.Windows.Forms.Label();
            this.lblAppointDate = new System.Windows.Forms.Label();
            this.rtfAppointDescription = new System.Windows.Forms.RichTextBox();
            this.cboV_RN = new System.Windows.Forms.ComboBox();
            this.cboE_ID = new System.Windows.Forms.ComboBox();
            this.pnlService.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmployeeName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmployeeName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeName.Location = new System.Drawing.Point(41, 248);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(96, 21);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Employee ID";
            // 
            // lblVehicleRegNumber
            // 
            this.lblVehicleRegNumber.AutoSize = true;
            this.lblVehicleRegNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleRegNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleRegNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVehicleRegNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleRegNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleRegNumber.Location = new System.Drawing.Point(41, 194);
            this.lblVehicleRegNumber.Name = "lblVehicleRegNumber";
            this.lblVehicleRegNumber.Size = new System.Drawing.Size(152, 21);
            this.lblVehicleRegNumber.TabIndex = 2;
            this.lblVehicleRegNumber.Text = "Vehicle Reg Number:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblService.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblService.Location = new System.Drawing.Point(292, 11);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(97, 33);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Service";
            // 
            // pnlService
            // 
            this.pnlService.BackColor = System.Drawing.Color.Transparent;
            this.pnlService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlService.Controls.Add(this.lblService);
            this.pnlService.Location = new System.Drawing.Point(27, 46);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(684, 66);
            this.pnlService.TabIndex = 10;
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(734, 24);
            this.mnuFleet.TabIndex = 12;
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(342, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(110, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(226, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(82, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(458, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtServiceID
            // 
            this.txtServiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceID.Location = new System.Drawing.Point(247, 133);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(247, 26);
            this.txtServiceID.TabIndex = 16;
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblServiceID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblServiceID.Location = new System.Drawing.Point(41, 140);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(82, 21);
            this.lblServiceID.TabIndex = 17;
            this.lblServiceID.Text = "Service ID:";
            // 
            // cboAppointTime
            // 
            this.cboAppointTime.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAppointTime.FormattingEnabled = true;
            this.cboAppointTime.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "14:00",
            "15:00",
            "16:00"});
            this.cboAppointTime.Location = new System.Drawing.Point(247, 349);
            this.cboAppointTime.Name = "cboAppointTime";
            this.cboAppointTime.Size = new System.Drawing.Size(247, 26);
            this.cboAppointTime.TabIndex = 19;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Location = new System.Drawing.Point(27, 562);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(684, 66);
            this.pnlButtons.TabIndex = 20;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblAppointmentTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAppointmentTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAppointmentTime.Location = new System.Drawing.Point(41, 356);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(144, 21);
            this.lblAppointmentTime.TabIndex = 18;
            this.lblAppointmentTime.Text = "Appointment Time:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Location = new System.Drawing.Point(247, 295);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(247, 26);
            this.dtpAppointmentDate.TabIndex = 6;
            // 
            // lblAppointDescription
            // 
            this.lblAppointDescription.AutoSize = true;
            this.lblAppointDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblAppointDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAppointDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAppointDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAppointDescription.Location = new System.Drawing.Point(41, 402);
            this.lblAppointDescription.Name = "lblAppointDescription";
            this.lblAppointDescription.Size = new System.Drawing.Size(188, 21);
            this.lblAppointDescription.TabIndex = 4;
            this.lblAppointDescription.Text = "Appointment Description:";
            // 
            // lblAppointDate
            // 
            this.lblAppointDate.AutoSize = true;
            this.lblAppointDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAppointDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAppointDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAppointDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAppointDate.Location = new System.Drawing.Point(41, 302);
            this.lblAppointDate.Name = "lblAppointDate";
            this.lblAppointDate.Size = new System.Drawing.Size(143, 21);
            this.lblAppointDate.TabIndex = 3;
            this.lblAppointDate.Text = "Appointment Date:";
            // 
            // rtfAppointDescription
            // 
            this.rtfAppointDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfAppointDescription.Location = new System.Drawing.Point(247, 403);
            this.rtfAppointDescription.Name = "rtfAppointDescription";
            this.rtfAppointDescription.Size = new System.Drawing.Size(344, 96);
            this.rtfAppointDescription.TabIndex = 7;
            this.rtfAppointDescription.Text = "";
            // 
            // cboV_RN
            // 
            this.cboV_RN.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboV_RN.FormattingEnabled = true;
            this.cboV_RN.Location = new System.Drawing.Point(247, 194);
            this.cboV_RN.Name = "cboV_RN";
            this.cboV_RN.Size = new System.Drawing.Size(247, 26);
            this.cboV_RN.TabIndex = 21;
            // 
            // cboE_ID
            // 
            this.cboE_ID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboE_ID.FormattingEnabled = true;
            this.cboE_ID.Location = new System.Drawing.Point(247, 248);
            this.cboE_ID.Name = "cboE_ID";
            this.cboE_ID.Size = new System.Drawing.Size(247, 26);
            this.cboE_ID.TabIndex = 22;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 685);
            this.Controls.Add(this.cboE_ID);
            this.Controls.Add(this.cboV_RN);
            this.Controls.Add(this.rtfAppointDescription);
            this.Controls.Add(this.lblAppointDescription);
            this.Controls.Add(this.lblAppointDate);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.cboAppointTime);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.lblAppointmentTime);
            this.Controls.Add(this.lblServiceID);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.lblVehicleRegNumber);
            this.Controls.Add(this.lblEmployeeName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmService_Load);
            this.pnlService.ResumeLayout(false);
            this.pnlService.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblVehicleRegNumber;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.ComboBox cboAppointTime;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblAppointDescription;
        private System.Windows.Forms.Label lblAppointDate;
        private System.Windows.Forms.RichTextBox rtfAppointDescription;
        private System.Windows.Forms.ComboBox cboV_RN;
        private System.Windows.Forms.ComboBox cboE_ID;
    }
}