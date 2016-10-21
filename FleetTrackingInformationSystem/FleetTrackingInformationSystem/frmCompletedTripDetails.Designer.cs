namespace FleetTrackingInformationSystem
{
    partial class frmCompletedTripDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompletedTripDetails));
            this.txtKM = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtVehicleIncidents = new System.Windows.Forms.TextBox();
            this.lblVehicleIncidents = new System.Windows.Forms.Label();
            this.txtFuelUsage = new System.Windows.Forms.TextBox();
            this.lblFuelUsage = new System.Windows.Forms.Label();
            this.lblTripID = new System.Windows.Forms.Label();
            this.cboT_ID = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlCTD = new System.Windows.Forms.Panel();
            this.lblFleet = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlButtons.SuspendLayout();
            this.pnlCTD.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKM
            // 
            this.txtKM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKM.Location = new System.Drawing.Point(214, 321);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(209, 26);
            this.txtKM.TabIndex = 24;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.BackColor = System.Drawing.Color.Transparent;
            this.lblKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblKm.Location = new System.Drawing.Point(50, 326);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(104, 21);
            this.lblKm.TabIndex = 23;
            this.lblKm.Text = "KM Travelled:";
            // 
            // txtVehicleIncidents
            // 
            this.txtVehicleIncidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleIncidents.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleIncidents.Location = new System.Drawing.Point(214, 228);
            this.txtVehicleIncidents.Multiline = true;
            this.txtVehicleIncidents.Name = "txtVehicleIncidents";
            this.txtVehicleIncidents.Size = new System.Drawing.Size(209, 55);
            this.txtVehicleIncidents.TabIndex = 21;
            // 
            // lblVehicleIncidents
            // 
            this.lblVehicleIncidents.AutoSize = true;
            this.lblVehicleIncidents.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleIncidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleIncidents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVehicleIncidents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleIncidents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleIncidents.Location = new System.Drawing.Point(50, 262);
            this.lblVehicleIncidents.Name = "lblVehicleIncidents";
            this.lblVehicleIncidents.Size = new System.Drawing.Size(129, 21);
            this.lblVehicleIncidents.TabIndex = 20;
            this.lblVehicleIncidents.Text = "Vehicle Incidents:";
            // 
            // txtFuelUsage
            // 
            this.txtFuelUsage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuelUsage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuelUsage.Location = new System.Drawing.Point(214, 181);
            this.txtFuelUsage.Name = "txtFuelUsage";
            this.txtFuelUsage.Size = new System.Drawing.Size(209, 26);
            this.txtFuelUsage.TabIndex = 22;
            // 
            // lblFuelUsage
            // 
            this.lblFuelUsage.AutoSize = true;
            this.lblFuelUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblFuelUsage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFuelUsage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFuelUsage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelUsage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFuelUsage.Location = new System.Drawing.Point(50, 196);
            this.lblFuelUsage.Name = "lblFuelUsage";
            this.lblFuelUsage.Size = new System.Drawing.Size(87, 21);
            this.lblFuelUsage.TabIndex = 19;
            this.lblFuelUsage.Text = "Fuel Usage:";
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.BackColor = System.Drawing.Color.Transparent;
            this.lblTripID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTripID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTripID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTripID.Location = new System.Drawing.Point(50, 139);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(59, 21);
            this.lblTripID.TabIndex = 25;
            this.lblTripID.Text = "Trip ID:";
            // 
            // cboT_ID
            // 
            this.cboT_ID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboT_ID.FormattingEnabled = true;
            this.cboT_ID.Location = new System.Drawing.Point(214, 134);
            this.cboT_ID.Name = "cboT_ID";
            this.cboT_ID.Size = new System.Drawing.Size(209, 26);
            this.cboT_ID.TabIndex = 26;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Location = new System.Drawing.Point(12, 407);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(530, 64);
            this.pnlButtons.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(23, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(420, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlCTD
            // 
            this.pnlCTD.BackColor = System.Drawing.Color.Transparent;
            this.pnlCTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCTD.Controls.Add(this.lblFleet);
            this.pnlCTD.Location = new System.Drawing.Point(17, 29);
            this.pnlCTD.Name = "pnlCTD";
            this.pnlCTD.Size = new System.Drawing.Size(525, 66);
            this.pnlCTD.TabIndex = 28;
            // 
            // lblFleet
            // 
            this.lblFleet.AutoSize = true;
            this.lblFleet.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFleet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFleet.Location = new System.Drawing.Point(133, 16);
            this.lblFleet.Name = "lblFleet";
            this.lblFleet.Size = new System.Drawing.Size(271, 33);
            this.lblFleet.TabIndex = 7;
            this.lblFleet.Text = "Completed Trip Details";
            this.lblFleet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(573, 24);
            this.mnuFleet.TabIndex = 29;
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
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(99, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmCompletedTripDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 498);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlCTD);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.cboT_ID);
            this.Controls.Add(this.lblTripID);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.txtVehicleIncidents);
            this.Controls.Add(this.lblVehicleIncidents);
            this.Controls.Add(this.txtFuelUsage);
            this.Controls.Add(this.lblFuelUsage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompletedTripDetails";
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmCompletedTripDetails_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlCTD.ResumeLayout(false);
            this.pnlCTD.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtVehicleIncidents;
        private System.Windows.Forms.Label lblVehicleIncidents;
        private System.Windows.Forms.TextBox txtFuelUsage;
        private System.Windows.Forms.Label lblFuelUsage;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.ComboBox cboT_ID;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlCTD;
        private System.Windows.Forms.Label lblFleet;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}