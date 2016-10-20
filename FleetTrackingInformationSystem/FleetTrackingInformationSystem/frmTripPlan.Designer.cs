namespace FleetTrackingInformationSystem
{
    partial class frmTripPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTripPlan));
            this.lblVehicleRegNo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTripUsage = new System.Windows.Forms.Label();
            this.pnlTripUsage = new System.Windows.Forms.Panel();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTripID = new System.Windows.Forms.Label();
            this.txtTripID = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.cboV_RN = new System.Windows.Forms.ComboBox();
            this.pbxQR = new System.Windows.Forms.PictureBox();
            this.btnGenQR = new System.Windows.Forms.Button();
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.lblCompleted = new System.Windows.Forms.LinkLabel();
            this.pnlTripUsage.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehicleRegNo
            // 
            this.lblVehicleRegNo.AutoSize = true;
            this.lblVehicleRegNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleRegNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVehicleRegNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleRegNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleRegNo.Location = new System.Drawing.Point(68, 203);
            this.lblVehicleRegNo.Name = "lblVehicleRegNo";
            this.lblVehicleRegNo.Size = new System.Drawing.Size(152, 21);
            this.lblVehicleRegNo.TabIndex = 0;
            this.lblVehicleRegNo.Text = "Vehicle Reg Number:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDateFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateFrom.Location = new System.Drawing.Point(68, 249);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(116, 21);
            this.lblDateFrom.TabIndex = 4;
            this.lblDateFrom.Text = "Trip Date From:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Location = new System.Drawing.Point(232, 244);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(197, 26);
            this.dtpDateFrom.TabIndex = 8;
            // 
            // lblTripUsage
            // 
            this.lblTripUsage.AutoSize = true;
            this.lblTripUsage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTripUsage.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripUsage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTripUsage.Location = new System.Drawing.Point(184, 10);
            this.lblTripUsage.Name = "lblTripUsage";
            this.lblTripUsage.Size = new System.Drawing.Size(133, 33);
            this.lblTripUsage.TabIndex = 10;
            this.lblTripUsage.Text = "Trip Usage";
            // 
            // pnlTripUsage
            // 
            this.pnlTripUsage.BackColor = System.Drawing.Color.Transparent;
            this.pnlTripUsage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTripUsage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTripUsage.Controls.Add(this.lblTripUsage);
            this.pnlTripUsage.Location = new System.Drawing.Point(40, 61);
            this.pnlTripUsage.Name = "pnlTripUsage";
            this.pnlTripUsage.Size = new System.Drawing.Size(530, 64);
            this.pnlTripUsage.TabIndex = 11;
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(594, 24);
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(290, 13);
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
            this.btnDelete.Location = new System.Drawing.Point(39, 13);
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
            this.btnAdd.Location = new System.Drawing.Point(163, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(404, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDateTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateTo.Location = new System.Drawing.Point(68, 301);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(97, 21);
            this.lblDateTo.TabIndex = 15;
            this.lblDateTo.Text = "Trip Date To:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Location = new System.Drawing.Point(232, 294);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(197, 26);
            this.dtpDateTo.TabIndex = 16;
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.BackColor = System.Drawing.Color.Transparent;
            this.lblTripID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTripID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTripID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTripID.Location = new System.Drawing.Point(68, 157);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(59, 21);
            this.lblTripID.TabIndex = 19;
            this.lblTripID.Text = "Trip ID:";
            // 
            // txtTripID
            // 
            this.txtTripID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTripID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripID.Location = new System.Drawing.Point(232, 150);
            this.txtTripID.Name = "txtTripID";
            this.txtTripID.Size = new System.Drawing.Size(197, 26);
            this.txtTripID.TabIndex = 20;
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
            this.pnlButtons.Location = new System.Drawing.Point(40, 593);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(530, 64);
            this.pnlButtons.TabIndex = 21;
            // 
            // cboV_RN
            // 
            this.cboV_RN.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboV_RN.FormattingEnabled = true;
            this.cboV_RN.Location = new System.Drawing.Point(232, 198);
            this.cboV_RN.Name = "cboV_RN";
            this.cboV_RN.Size = new System.Drawing.Size(197, 26);
            this.cboV_RN.TabIndex = 22;
            // 
            // pbxQR
            // 
            this.pbxQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxQR.Location = new System.Drawing.Point(40, 417);
            this.pbxQR.Name = "pbxQR";
            this.pbxQR.Size = new System.Drawing.Size(194, 170);
            this.pbxQR.TabIndex = 23;
            this.pbxQR.TabStop = false;
            // 
            // btnGenQR
            // 
            this.btnGenQR.Location = new System.Drawing.Point(264, 417);
            this.btnGenQR.Name = "btnGenQR";
            this.btnGenQR.Size = new System.Drawing.Size(181, 23);
            this.btnGenQR.TabIndex = 24;
            this.btnGenQR.Text = "Generate QR Code";
            this.btnGenQR.UseVisualStyleBackColor = true;
            this.btnGenQR.Click += new System.EventHandler(this.btnGenQR_Click);
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(264, 456);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(95, 23);
            this.btnSaveQR.TabIndex = 25;
            this.btnSaveQR.Text = "Save QR Image";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCompleted.Location = new System.Drawing.Point(392, 673);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(178, 13);
            this.lblCompleted.TabIndex = 26;
            this.lblCompleted.TabStop = true;
            this.lblCompleted.Text = "Click here if trip has been completed";
            this.lblCompleted.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCompleted_LinkClicked);
            // 
            // frmTripPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 695);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.btnGenQR);
            this.Controls.Add(this.pbxQR);
            this.Controls.Add(this.cboV_RN);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtTripID);
            this.Controls.Add(this.lblTripID);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.pnlTripUsage);
            this.Controls.Add(this.lblVehicleRegNo);
            this.Controls.Add(this.lblDateFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTripPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmTripUsage_Load);
            this.pnlTripUsage.ResumeLayout(false);
            this.pnlTripUsage.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleRegNo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblTripUsage;
        private System.Windows.Forms.Panel pnlTripUsage;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.TextBox txtTripID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ComboBox cboV_RN;
        private System.Windows.Forms.PictureBox pbxQR;
        private System.Windows.Forms.Button btnGenQR;
        private System.Windows.Forms.Button btnSaveQR;
        private System.Windows.Forms.LinkLabel lblCompleted;
    }
}