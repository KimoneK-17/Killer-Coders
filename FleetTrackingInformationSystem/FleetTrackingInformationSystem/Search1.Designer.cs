namespace FleetTrackingInformationSystem
{
    partial class Search1
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
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabCust = new System.Windows.Forms.TabPage();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.lblCustID = new System.Windows.Forms.Label();
            this.tabTripUsage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblTripID = new System.Windows.Forms.Label();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.lblVehicleRN = new System.Windows.Forms.Label();
            this.tabService = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboC_ID = new System.Windows.Forms.ComboBox();
            this.cboT_ID = new System.Windows.Forms.ComboBox();
            this.cboE_ID = new System.Windows.Forms.ComboBox();
            this.cboL_ID = new System.Windows.Forms.ComboBox();
            this.cboV_RN = new System.Windows.Forms.ComboBox();
            this.cboS_ID = new System.Windows.Forms.ComboBox();
            this.tabSearch.SuspendLayout();
            this.tabCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.tabTripUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.mnuFleet.SuspendLayout();
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
            this.tabSearch.Location = new System.Drawing.Point(0, 27);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.Size = new System.Drawing.Size(952, 377);
            this.tabSearch.TabIndex = 17;
            // 
            // tabCust
            // 
            this.tabCust.AutoScroll = true;
            this.tabCust.Controls.Add(this.cboC_ID);
            this.tabCust.Controls.Add(this.dgvSearch);
            this.tabCust.Controls.Add(this.lblCustID);
            this.tabCust.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCust.Location = new System.Drawing.Point(4, 22);
            this.tabCust.Name = "tabCust";
            this.tabCust.Padding = new System.Windows.Forms.Padding(3);
            this.tabCust.Size = new System.Drawing.Size(944, 351);
            this.tabCust.TabIndex = 0;
            this.tabCust.Text = "Customer";
            this.tabCust.UseVisualStyleBackColor = true;
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(27, 95);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(908, 233);
            this.dgvSearch.TabIndex = 2;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(27, 34);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(84, 18);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "Customer ID";
            // 
            // tabTripUsage
            // 
            this.tabTripUsage.Controls.Add(this.cboT_ID);
            this.tabTripUsage.Controls.Add(this.dataGridView2);
            this.tabTripUsage.Controls.Add(this.lblTripID);
            this.tabTripUsage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTripUsage.Location = new System.Drawing.Point(4, 22);
            this.tabTripUsage.Name = "tabTripUsage";
            this.tabTripUsage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTripUsage.Size = new System.Drawing.Size(944, 351);
            this.tabTripUsage.TabIndex = 1;
            this.tabTripUsage.Text = "TripUsage";
            this.tabTripUsage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(908, 233);
            this.dataGridView2.TabIndex = 3;
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.Location = new System.Drawing.Point(20, 33);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(47, 18);
            this.lblTripID.TabIndex = 1;
            this.lblTripID.Text = "Trip ID";
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.cboE_ID);
            this.tabEmployee.Controls.Add(this.dataGridView3);
            this.tabEmployee.Controls.Add(this.lblEmpID);
            this.tabEmployee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(944, 351);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(22, 95);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(908, 233);
            this.dataGridView3.TabIndex = 3;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(25, 44);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(89, 18);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "Employee ID ";
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.cboL_ID);
            this.tabLocation.Controls.Add(this.dataGridView4);
            this.tabLocation.Controls.Add(this.lblLocationID);
            this.tabLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.Location = new System.Drawing.Point(4, 22);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(944, 351);
            this.tabLocation.TabIndex = 3;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(20, 97);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(908, 233);
            this.dataGridView4.TabIndex = 3;
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Location = new System.Drawing.Point(17, 37);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(75, 18);
            this.lblLocationID.TabIndex = 1;
            this.lblLocationID.Text = "Location ID";
            // 
            // tabVehicle
            // 
            this.tabVehicle.Controls.Add(this.cboV_RN);
            this.tabVehicle.Controls.Add(this.dataGridView5);
            this.tabVehicle.Controls.Add(this.lblVehicleRN);
            this.tabVehicle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Size = new System.Drawing.Size(944, 351);
            this.tabVehicle.TabIndex = 4;
            this.tabVehicle.Text = "Vehicle";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(26, 100);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(908, 233);
            this.dataGridView5.TabIndex = 3;
            // 
            // lblVehicleRN
            // 
            this.lblVehicleRN.AutoSize = true;
            this.lblVehicleRN.Location = new System.Drawing.Point(23, 34);
            this.lblVehicleRN.Name = "lblVehicleRN";
            this.lblVehicleRN.Size = new System.Drawing.Size(131, 18);
            this.lblVehicleRN.TabIndex = 1;
            this.lblVehicleRN.Text = "Vehicle RegNumber";
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.cboS_ID);
            this.tabService.Controls.Add(this.dataGridView6);
            this.tabService.Controls.Add(this.lblServiceID);
            this.tabService.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(944, 351);
            this.tabService.TabIndex = 5;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(34, 101);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(908, 233);
            this.dataGridView6.TabIndex = 3;
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(31, 37);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(69, 18);
            this.lblServiceID.TabIndex = 1;
            this.lblServiceID.Text = "Service ID";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(960, 24);
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
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(99, 22);
            this.mnuExit.Text = "Exit";
            // 
            // cboC_ID
            // 
            this.cboC_ID.FormattingEnabled = true;
            this.cboC_ID.Location = new System.Drawing.Point(187, 30);
            this.cboC_ID.Name = "cboC_ID";
            this.cboC_ID.Size = new System.Drawing.Size(121, 26);
            this.cboC_ID.TabIndex = 3;
            // 
            // cboT_ID
            // 
            this.cboT_ID.FormattingEnabled = true;
            this.cboT_ID.Location = new System.Drawing.Point(147, 33);
            this.cboT_ID.Name = "cboT_ID";
            this.cboT_ID.Size = new System.Drawing.Size(121, 26);
            this.cboT_ID.TabIndex = 4;
            // 
            // cboE_ID
            // 
            this.cboE_ID.FormattingEnabled = true;
            this.cboE_ID.Location = new System.Drawing.Point(171, 36);
            this.cboE_ID.Name = "cboE_ID";
            this.cboE_ID.Size = new System.Drawing.Size(121, 26);
            this.cboE_ID.TabIndex = 4;
            // 
            // cboL_ID
            // 
            this.cboL_ID.FormattingEnabled = true;
            this.cboL_ID.Location = new System.Drawing.Point(147, 37);
            this.cboL_ID.Name = "cboL_ID";
            this.cboL_ID.Size = new System.Drawing.Size(121, 26);
            this.cboL_ID.TabIndex = 4;
            // 
            // cboV_RN
            // 
            this.cboV_RN.FormattingEnabled = true;
            this.cboV_RN.Location = new System.Drawing.Point(213, 34);
            this.cboV_RN.Name = "cboV_RN";
            this.cboV_RN.Size = new System.Drawing.Size(121, 26);
            this.cboV_RN.TabIndex = 4;
            // 
            // cboS_ID
            // 
            this.cboS_ID.FormattingEnabled = true;
            this.cboS_ID.Location = new System.Drawing.Point(171, 34);
            this.cboS_ID.Name = "cboS_ID";
            this.cboS_ID.Size = new System.Drawing.Size(121, 26);
            this.cboS_ID.TabIndex = 4;
            // 
            // Search1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 409);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.tabSearch);
            this.Name = "Search1";
            this.Text = "Search1";
            this.tabSearch.ResumeLayout(false);
            this.tabCust.ResumeLayout(false);
            this.tabCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.tabTripUsage.ResumeLayout(false);
            this.tabTripUsage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabLocation.ResumeLayout(false);
            this.tabLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabVehicle.ResumeLayout(false);
            this.tabVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tabCust;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TabPage tabTripUsage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label lblVehicleRN;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.DataGridView dataGridView6;
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
    }
}