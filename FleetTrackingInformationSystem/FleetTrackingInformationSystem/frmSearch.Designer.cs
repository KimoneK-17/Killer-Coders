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
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.fleetTrackingDBDataSet1 = new FleetTrackingInformationSystem.FleetTrackingDBDataSet();
            this.fleetTrackingDBDataSet = new FleetTrackingInformationSystem.FleetTrackingDBDataSet();
            this.customerTableAdapter1 = new FleetTrackingInformationSystem.FleetTrackingDBDataSetTableAdapters.CustomerTableAdapter();
            this.tabService = new System.Windows.Forms.TabPage();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabTripUsage = new System.Windows.Forms.TabPage();
            this.tabCust = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.lblCustID = new System.Windows.Forms.Label();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.tbTripID = new System.Windows.Forms.TextBox();
            this.tbLocationID = new System.Windows.Forms.TextBox();
            this.tbVehicleRegNumber = new System.Windows.Forms.TextBox();
            this.tbServiceID = new System.Windows.Forms.TextBox();
            this.lblTripID = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.lblVehicleRN = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.mnuFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fleetTrackingDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetTrackingDBDataSet)).BeginInit();
            this.tabService.SuspendLayout();
            this.tabVehicle.SuspendLayout();
            this.tabLocation.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tabTripUsage.SuspendLayout();
            this.tabCust.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(967, 24);
            this.mnuFleet.TabIndex = 15;
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
            // fleetTrackingDBDataSet1
            // 
            this.fleetTrackingDBDataSet1.DataSetName = "FleetTrackingDBDataSet";
            this.fleetTrackingDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fleetTrackingDBDataSet
            // 
            this.fleetTrackingDBDataSet.DataSetName = "FleetTrackingDBDataSet";
            this.fleetTrackingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.dataGridView6);
            this.tabService.Controls.Add(this.lblServiceID);
            this.tabService.Controls.Add(this.tbServiceID);
            this.tabService.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(959, 352);
            this.tabService.TabIndex = 5;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // tabVehicle
            // 
            this.tabVehicle.Controls.Add(this.dataGridView5);
            this.tabVehicle.Controls.Add(this.lblVehicleRN);
            this.tabVehicle.Controls.Add(this.tbVehicleRegNumber);
            this.tabVehicle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Size = new System.Drawing.Size(959, 352);
            this.tabVehicle.TabIndex = 4;
            this.tabVehicle.Text = "Vehicle";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.dataGridView4);
            this.tabLocation.Controls.Add(this.lblLocationID);
            this.tabLocation.Controls.Add(this.tbLocationID);
            this.tabLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.Location = new System.Drawing.Point(4, 22);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(959, 352);
            this.tabLocation.TabIndex = 3;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.dataGridView3);
            this.tabEmployee.Controls.Add(this.lblEmpID);
            this.tabEmployee.Controls.Add(this.tbEmpID);
            this.tabEmployee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(959, 352);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabTripUsage
            // 
            this.tabTripUsage.Controls.Add(this.dataGridView2);
            this.tabTripUsage.Controls.Add(this.lblTripID);
            this.tabTripUsage.Controls.Add(this.tbTripID);
            this.tabTripUsage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTripUsage.Location = new System.Drawing.Point(4, 22);
            this.tabTripUsage.Name = "tabTripUsage";
            this.tabTripUsage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTripUsage.Size = new System.Drawing.Size(959, 352);
            this.tabTripUsage.TabIndex = 1;
            this.tabTripUsage.Text = "TripUsage";
            this.tabTripUsage.UseVisualStyleBackColor = true;
            // 
            // tabCust
            // 
            this.tabCust.AutoScroll = true;
            this.tabCust.Controls.Add(this.dataGridView1);
            this.tabCust.Controls.Add(this.tbCustID);
            this.tabCust.Controls.Add(this.lblCustID);
            this.tabCust.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCust.Location = new System.Drawing.Point(4, 22);
            this.tabCust.Name = "tabCust";
            this.tabCust.Padding = new System.Windows.Forms.Padding(3);
            this.tabCust.Size = new System.Drawing.Size(959, 352);
            this.tabCust.TabIndex = 0;
            this.tabCust.Text = "Customer";
            this.tabCust.UseVisualStyleBackColor = true;
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
            this.tabSearch.Size = new System.Drawing.Size(967, 378);
            this.tabSearch.TabIndex = 16;
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
            // tbCustID
            // 
            this.tbCustID.Location = new System.Drawing.Point(180, 31);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.Size = new System.Drawing.Size(100, 26);
            this.tbCustID.TabIndex = 1;
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(144, 27);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(100, 26);
            this.tbEmpID.TabIndex = 0;
            // 
            // tbTripID
            // 
            this.tbTripID.Location = new System.Drawing.Point(108, 30);
            this.tbTripID.Name = "tbTripID";
            this.tbTripID.Size = new System.Drawing.Size(100, 26);
            this.tbTripID.TabIndex = 0;
            // 
            // tbLocationID
            // 
            this.tbLocationID.Location = new System.Drawing.Point(134, 34);
            this.tbLocationID.Name = "tbLocationID";
            this.tbLocationID.Size = new System.Drawing.Size(100, 26);
            this.tbLocationID.TabIndex = 0;
            // 
            // tbVehicleRegNumber
            // 
            this.tbVehicleRegNumber.Location = new System.Drawing.Point(198, 31);
            this.tbVehicleRegNumber.Name = "tbVehicleRegNumber";
            this.tbVehicleRegNumber.Size = new System.Drawing.Size(100, 26);
            this.tbVehicleRegNumber.TabIndex = 0;
            // 
            // tbServiceID
            // 
            this.tbServiceID.Location = new System.Drawing.Point(132, 34);
            this.tbServiceID.Name = "tbServiceID";
            this.tbServiceID.Size = new System.Drawing.Size(100, 26);
            this.tbServiceID.TabIndex = 0;
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
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(19, 35);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(89, 18);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "Employee ID ";
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
            // lblVehicleRN
            // 
            this.lblVehicleRN.AutoSize = true;
            this.lblVehicleRN.Location = new System.Drawing.Point(23, 34);
            this.lblVehicleRN.Name = "lblVehicleRN";
            this.lblVehicleRN.Size = new System.Drawing.Size(131, 18);
            this.lblVehicleRN.TabIndex = 1;
            this.lblVehicleRN.Text = "Vehicle RegNumber";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 233);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(908, 233);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(22, 95);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(908, 233);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(20, 97);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(908, 233);
            this.dataGridView4.TabIndex = 3;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(26, 100);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(908, 233);
            this.dataGridView5.TabIndex = 3;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(34, 101);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(908, 233);
            this.dataGridView6.TabIndex = 3;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 405);
            this.Controls.Add(this.tabSearch);
            this.Controls.Add(this.mnuFleet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fleetTrackingDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetTrackingDBDataSet)).EndInit();
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            this.tabVehicle.ResumeLayout(false);
            this.tabVehicle.PerformLayout();
            this.tabLocation.ResumeLayout(false);
            this.tabLocation.PerformLayout();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.tabTripUsage.ResumeLayout(false);
            this.tabTripUsage.PerformLayout();
            this.tabCust.ResumeLayout(false);
            this.tabCust.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private FleetTrackingDBDataSet fleetTrackingDBDataSet;
        private FleetTrackingDBDataSet fleetTrackingDBDataSet1;
        private FleetTrackingDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabTripUsage;
        private System.Windows.Forms.TabPage tabCust;
        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox tbCustID;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox tbServiceID;
        private System.Windows.Forms.Label lblVehicleRN;
        private System.Windows.Forms.TextBox tbVehicleRegNumber;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.TextBox tbLocationID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.TextBox tbTripID;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
    }
}