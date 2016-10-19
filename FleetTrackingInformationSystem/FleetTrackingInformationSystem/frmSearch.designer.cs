namespace FleetTrackingInformationSystem
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabCust = new System.Windows.Forms.TabPage();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.cboC_ID = new System.Windows.Forms.ComboBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.lblCustID = new System.Windows.Forms.Label();
            this.tabTripUsage = new System.Windows.Forms.TabPage();
            this.btnTrip = new System.Windows.Forms.Button();
            this.cboT_ID = new System.Windows.Forms.ComboBox();
            this.dgvTripUsage = new System.Windows.Forms.DataGridView();
            this.lblTripID = new System.Windows.Forms.Label();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.btnEmp = new System.Windows.Forms.Button();
            this.cboE_ID = new System.Windows.Forms.ComboBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.btnLocation = new System.Windows.Forms.Button();
            this.cboL_ID = new System.Windows.Forms.ComboBox();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.cboV_RN = new System.Windows.Forms.ComboBox();
            this.dgvVehicleRegNum = new System.Windows.Forms.DataGridView();
            this.lblVehicleRN = new System.Windows.Forms.Label();
            this.tabService = new System.Windows.Forms.TabPage();
            this.btnService = new System.Windows.Forms.Button();
            this.cboS_ID = new System.Windows.Forms.ComboBox();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tabSearch.SuspendLayout();
            this.tabCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.tabTripUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripUsage)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            this.tabVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRegNum)).BeginInit();
            this.tabService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.mnuFleet.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.tabCust);
            this.tabSearch.Controls.Add(this.tabTripUsage);
            this.tabSearch.Controls.Add(this.tabEmployee);
            this.tabSearch.Controls.Add(this.tabLocation);
            this.tabSearch.Controls.Add(this.tabVehicle);
            this.tabSearch.Controls.Add(this.tabService);
            this.tabSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.Location = new System.Drawing.Point(27, 137);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.Size = new System.Drawing.Size(1041, 456);
            this.tabSearch.TabIndex = 17;
            // 
            // tabCust
            // 
            this.tabCust.AutoScroll = true;
            this.tabCust.Controls.Add(this.btnEmployee);
            this.tabCust.Controls.Add(this.cboC_ID);
            this.tabCust.Controls.Add(this.dgvSearch);
            this.tabCust.Controls.Add(this.lblCustID);
            this.tabCust.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCust.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabCust.Location = new System.Drawing.Point(4, 28);
            this.tabCust.Name = "tabCust";
            this.tabCust.Padding = new System.Windows.Forms.Padding(3);
            this.tabCust.Size = new System.Drawing.Size(1033, 424);
            this.tabCust.TabIndex = 0;
            this.tabCust.Text = "Customer";
            this.tabCust.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployee.Location = new System.Drawing.Point(899, 39);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(82, 35);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Search";
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // cboC_ID
            // 
            this.cboC_ID.FormattingEnabled = true;
            this.cboC_ID.Location = new System.Drawing.Point(137, 35);
            this.cboC_ID.Name = "cboC_ID";
            this.cboC_ID.Size = new System.Drawing.Size(209, 27);
            this.cboC_ID.TabIndex = 3;
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(27, 95);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(978, 292);
            this.dgvSearch.TabIndex = 2;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCustID.Location = new System.Drawing.Point(23, 43);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(92, 19);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "Customer ID";
            // 
            // tabTripUsage
            // 
            this.tabTripUsage.Controls.Add(this.btnTrip);
            this.tabTripUsage.Controls.Add(this.cboT_ID);
            this.tabTripUsage.Controls.Add(this.dgvTripUsage);
            this.tabTripUsage.Controls.Add(this.lblTripID);
            this.tabTripUsage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTripUsage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabTripUsage.Location = new System.Drawing.Point(4, 28);
            this.tabTripUsage.Name = "tabTripUsage";
            this.tabTripUsage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTripUsage.Size = new System.Drawing.Size(1033, 424);
            this.tabTripUsage.TabIndex = 1;
            this.tabTripUsage.Text = "TripUsage";
            this.tabTripUsage.UseVisualStyleBackColor = true;
            // 
            // btnTrip
            // 
            this.btnTrip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrip.Location = new System.Drawing.Point(899, 39);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(82, 35);
            this.btnTrip.TabIndex = 5;
            this.btnTrip.Text = "Search";
            this.btnTrip.UseVisualStyleBackColor = true;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // cboT_ID
            // 
            this.cboT_ID.FormattingEnabled = true;
            this.cboT_ID.Location = new System.Drawing.Point(137, 35);
            this.cboT_ID.Name = "cboT_ID";
            this.cboT_ID.Size = new System.Drawing.Size(209, 27);
            this.cboT_ID.TabIndex = 4;
            // 
            // dgvTripUsage
            // 
            this.dgvTripUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTripUsage.Location = new System.Drawing.Point(27, 95);
            this.dgvTripUsage.Name = "dgvTripUsage";
            this.dgvTripUsage.Size = new System.Drawing.Size(978, 292);
            this.dgvTripUsage.TabIndex = 3;
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.Location = new System.Drawing.Point(23, 43);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(53, 19);
            this.lblTripID.TabIndex = 1;
            this.lblTripID.Text = "Trip ID";
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.btnEmp);
            this.tabEmployee.Controls.Add(this.cboE_ID);
            this.tabEmployee.Controls.Add(this.dgvEmployee);
            this.tabEmployee.Controls.Add(this.lblEmpID);
            this.tabEmployee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabEmployee.Location = new System.Drawing.Point(4, 28);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(1033, 424);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEmp
            // 
            this.btnEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmp.Location = new System.Drawing.Point(899, 39);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(82, 35);
            this.btnEmp.TabIndex = 5;
            this.btnEmp.Text = "Search";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // cboE_ID
            // 
            this.cboE_ID.FormattingEnabled = true;
            this.cboE_ID.Location = new System.Drawing.Point(137, 35);
            this.cboE_ID.Name = "cboE_ID";
            this.cboE_ID.Size = new System.Drawing.Size(184, 27);
            this.cboE_ID.TabIndex = 4;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(27, 95);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(978, 292);
            this.dgvEmployee.TabIndex = 3;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(23, 43);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(98, 19);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "Employee ID ";
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.btnLocation);
            this.tabLocation.Controls.Add(this.cboL_ID);
            this.tabLocation.Controls.Add(this.dgvLocation);
            this.tabLocation.Controls.Add(this.lblLocationID);
            this.tabLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabLocation.Location = new System.Drawing.Point(4, 28);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(1033, 424);
            this.tabLocation.TabIndex = 3;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // btnLocation
            // 
            this.btnLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLocation.Location = new System.Drawing.Point(899, 39);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(82, 35);
            this.btnLocation.TabIndex = 5;
            this.btnLocation.Text = "Search";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // cboL_ID
            // 
            this.cboL_ID.FormattingEnabled = true;
            this.cboL_ID.Location = new System.Drawing.Point(137, 35);
            this.cboL_ID.Name = "cboL_ID";
            this.cboL_ID.Size = new System.Drawing.Size(195, 27);
            this.cboL_ID.TabIndex = 4;
            // 
            // dgvLocation
            // 
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation.Location = new System.Drawing.Point(27, 95);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.Size = new System.Drawing.Size(978, 292);
            this.dgvLocation.TabIndex = 3;
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Location = new System.Drawing.Point(23, 43);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(85, 19);
            this.lblLocationID.TabIndex = 1;
            this.lblLocationID.Text = "Location ID";
            // 
            // tabVehicle
            // 
            this.tabVehicle.Controls.Add(this.btnVehicle);
            this.tabVehicle.Controls.Add(this.cboV_RN);
            this.tabVehicle.Controls.Add(this.dgvVehicleRegNum);
            this.tabVehicle.Controls.Add(this.lblVehicleRN);
            this.tabVehicle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabVehicle.Location = new System.Drawing.Point(4, 28);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Size = new System.Drawing.Size(1033, 424);
            this.tabVehicle.TabIndex = 4;
            this.tabVehicle.Text = "Vehicle";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // btnVehicle
            // 
            this.btnVehicle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVehicle.Location = new System.Drawing.Point(899, 39);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(82, 35);
            this.btnVehicle.TabIndex = 5;
            this.btnVehicle.Text = "Search";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // cboV_RN
            // 
            this.cboV_RN.FormattingEnabled = true;
            this.cboV_RN.Location = new System.Drawing.Point(175, 35);
            this.cboV_RN.Name = "cboV_RN";
            this.cboV_RN.Size = new System.Drawing.Size(192, 27);
            this.cboV_RN.TabIndex = 4;
            // 
            // dgvVehicleRegNum
            // 
            this.dgvVehicleRegNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleRegNum.Location = new System.Drawing.Point(27, 95);
            this.dgvVehicleRegNum.Name = "dgvVehicleRegNum";
            this.dgvVehicleRegNum.Size = new System.Drawing.Size(978, 292);
            this.dgvVehicleRegNum.TabIndex = 3;
            // 
            // lblVehicleRN
            // 
            this.lblVehicleRN.AutoSize = true;
            this.lblVehicleRN.Location = new System.Drawing.Point(23, 43);
            this.lblVehicleRN.Name = "lblVehicleRN";
            this.lblVehicleRN.Size = new System.Drawing.Size(146, 19);
            this.lblVehicleRN.TabIndex = 1;
            this.lblVehicleRN.Text = "Vehicle Reg Number";
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.btnService);
            this.tabService.Controls.Add(this.cboS_ID);
            this.tabService.Controls.Add(this.dgvService);
            this.tabService.Controls.Add(this.lblServiceID);
            this.tabService.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabService.Location = new System.Drawing.Point(4, 28);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(1033, 424);
            this.tabService.TabIndex = 5;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // btnService
            // 
            this.btnService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnService.Location = new System.Drawing.Point(899, 39);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(82, 35);
            this.btnService.TabIndex = 5;
            this.btnService.Text = "Search";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // cboS_ID
            // 
            this.cboS_ID.FormattingEnabled = true;
            this.cboS_ID.Location = new System.Drawing.Point(137, 35);
            this.cboS_ID.Name = "cboS_ID";
            this.cboS_ID.Size = new System.Drawing.Size(191, 27);
            this.cboS_ID.TabIndex = 4;
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(27, 95);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(978, 292);
            this.dgvService.TabIndex = 3;
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(23, 43);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(76, 19);
            this.lblServiceID.TabIndex = 1;
            this.lblServiceID.Text = "Service ID";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(1096, 24);
            this.mnuFleet.TabIndex = 18;
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
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Location = new System.Drawing.Point(27, 41);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1041, 66);
            this.pnlSearch.TabIndex = 19;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearch.Location = new System.Drawing.Point(476, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(105, 39);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1096, 632);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.tabSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.tabSearch.ResumeLayout(false);
            this.tabCust.ResumeLayout(false);
            this.tabCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.tabTripUsage.ResumeLayout(false);
            this.tabTripUsage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripUsage)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabLocation.ResumeLayout(false);
            this.tabLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            this.tabVehicle.ResumeLayout(false);
            this.tabVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRegNum)).EndInit();
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tabCust;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TabPage tabTripUsage;
        private System.Windows.Forms.DataGridView dgvTripUsage;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.DataGridView dgvVehicleRegNum;
        private System.Windows.Forms.Label lblVehicleRN;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ComboBox cboC_ID;
        private System.Windows.Forms.ComboBox cboT_ID;
        private System.Windows.Forms.ComboBox cboE_ID;
        private System.Windows.Forms.ComboBox cboL_ID;
        private System.Windows.Forms.ComboBox cboV_RN;
        private System.Windows.Forms.ComboBox cboS_ID;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnTrip;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnService;
    }
}