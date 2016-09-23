namespace FleetTrackingInformationSystem
{
    partial class frmReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FleetTrackingDBDataSet = new FleetTrackingInformationSystem.FleetTrackingDBDataSet();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabVehicleStat = new System.Windows.Forms.TabPage();
            this.reportV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabServiceAppoint = new System.Windows.Forms.TabPage();
            this.tabServiceRequire = new System.Windows.Forms.TabPage();
            this.tabVehicleServiceCompleted = new System.Windows.Forms.TabPage();
            this.tabDetailedServiceInfo = new System.Windows.Forms.TabPage();
            this.tabPlannedTrip = new System.Windows.Forms.TabPage();
            this.tabCompletedTrip = new System.Windows.Forms.TabPage();
            this.tabTimesheet = new System.Windows.Forms.TabPage();
            this.VehicleTableAdapter = new FleetTrackingInformationSystem.FleetTrackingDBDataSetTableAdapters.VehicleTableAdapter();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FleetTrackingDBDataSet)).BeginInit();
            this.tabReports.SuspendLayout();
            this.tabVehicleStat.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleBindingSource
            // 
            this.VehicleBindingSource.DataMember = "Vehicle";
            this.VehicleBindingSource.DataSource = this.FleetTrackingDBDataSet;
            // 
            // FleetTrackingDBDataSet
            // 
            this.FleetTrackingDBDataSet.DataSetName = "FleetTrackingDBDataSet";
            this.FleetTrackingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabVehicleStat);
            this.tabReports.Controls.Add(this.tabServiceAppoint);
            this.tabReports.Controls.Add(this.tabServiceRequire);
            this.tabReports.Controls.Add(this.tabVehicleServiceCompleted);
            this.tabReports.Controls.Add(this.tabDetailedServiceInfo);
            this.tabReports.Controls.Add(this.tabPlannedTrip);
            this.tabReports.Controls.Add(this.tabCompletedTrip);
            this.tabReports.Controls.Add(this.tabTimesheet);
            this.tabReports.Location = new System.Drawing.Point(70, 140);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(1023, 472);
            this.tabReports.TabIndex = 0;
            // 
            // tabVehicleStat
            // 
            this.tabVehicleStat.Controls.Add(this.reportV);
            this.tabVehicleStat.Location = new System.Drawing.Point(4, 22);
            this.tabVehicleStat.Name = "tabVehicleStat";
            this.tabVehicleStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleStat.Size = new System.Drawing.Size(1015, 446);
            this.tabVehicleStat.TabIndex = 0;
            this.tabVehicleStat.Text = "Vehicle Status Report";
            this.tabVehicleStat.UseVisualStyleBackColor = true;
            // 
            // reportV
            // 
            this.reportV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VehicleBindingSource;
            this.reportV.LocalReport.DataSources.Add(reportDataSource1);
            this.reportV.LocalReport.ReportEmbeddedResource = "FleetTrackingInformationSystem.Report1.rdlc";
            this.reportV.Location = new System.Drawing.Point(3, 3);
            this.reportV.Name = "reportV";
            this.reportV.Size = new System.Drawing.Size(1009, 440);
            this.reportV.TabIndex = 0;
            // 
            // tabServiceAppoint
            // 
            this.tabServiceAppoint.Location = new System.Drawing.Point(4, 22);
            this.tabServiceAppoint.Name = "tabServiceAppoint";
            this.tabServiceAppoint.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceAppoint.Size = new System.Drawing.Size(1015, 446);
            this.tabServiceAppoint.TabIndex = 1;
            this.tabServiceAppoint.Text = "Service Appointment list";
            this.tabServiceAppoint.UseVisualStyleBackColor = true;
            // 
            // tabServiceRequire
            // 
            this.tabServiceRequire.Location = new System.Drawing.Point(4, 22);
            this.tabServiceRequire.Name = "tabServiceRequire";
            this.tabServiceRequire.Size = new System.Drawing.Size(1015, 446);
            this.tabServiceRequire.TabIndex = 2;
            this.tabServiceRequire.Text = "Service Requirement Job Sheet";
            this.tabServiceRequire.UseVisualStyleBackColor = true;
            // 
            // tabVehicleServiceCompleted
            // 
            this.tabVehicleServiceCompleted.Location = new System.Drawing.Point(4, 22);
            this.tabVehicleServiceCompleted.Name = "tabVehicleServiceCompleted";
            this.tabVehicleServiceCompleted.Size = new System.Drawing.Size(1015, 446);
            this.tabVehicleServiceCompleted.TabIndex = 3;
            this.tabVehicleServiceCompleted.Text = "Vehicle Services Completed";
            this.tabVehicleServiceCompleted.UseVisualStyleBackColor = true;
            // 
            // tabDetailedServiceInfo
            // 
            this.tabDetailedServiceInfo.Location = new System.Drawing.Point(4, 22);
            this.tabDetailedServiceInfo.Name = "tabDetailedServiceInfo";
            this.tabDetailedServiceInfo.Size = new System.Drawing.Size(1015, 446);
            this.tabDetailedServiceInfo.TabIndex = 4;
            this.tabDetailedServiceInfo.Text = "Detailed Service Information";
            this.tabDetailedServiceInfo.UseVisualStyleBackColor = true;
            // 
            // tabPlannedTrip
            // 
            this.tabPlannedTrip.Location = new System.Drawing.Point(4, 22);
            this.tabPlannedTrip.Name = "tabPlannedTrip";
            this.tabPlannedTrip.Size = new System.Drawing.Size(1015, 446);
            this.tabPlannedTrip.TabIndex = 5;
            this.tabPlannedTrip.Text = "Planned Trip Report";
            this.tabPlannedTrip.UseVisualStyleBackColor = true;
            // 
            // tabCompletedTrip
            // 
            this.tabCompletedTrip.Location = new System.Drawing.Point(4, 22);
            this.tabCompletedTrip.Name = "tabCompletedTrip";
            this.tabCompletedTrip.Size = new System.Drawing.Size(1015, 446);
            this.tabCompletedTrip.TabIndex = 6;
            this.tabCompletedTrip.Text = "Completed Trip Report";
            this.tabCompletedTrip.UseVisualStyleBackColor = true;
            // 
            // tabTimesheet
            // 
            this.tabTimesheet.Location = new System.Drawing.Point(4, 22);
            this.tabTimesheet.Name = "tabTimesheet";
            this.tabTimesheet.Size = new System.Drawing.Size(1015, 446);
            this.tabTimesheet.TabIndex = 7;
            this.tabTimesheet.Text = "Time Sheet Report";
            this.tabTimesheet.UseVisualStyleBackColor = true;
            // 
            // VehicleTableAdapter
            // 
            this.VehicleTableAdapter.ClearBeforeFill = true;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCustomer.Controls.Add(this.lblCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(70, 41);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(1016, 66);
            this.pnlCustomer.TabIndex = 10;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(443, 13);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(103, 33);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "Reports";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(1148, 24);
            this.mnuFleet.TabIndex = 14;
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
            this.mnuBack.Size = new System.Drawing.Size(152, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1148, 643);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.tabReports);
            this.Name = "frmReports";
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FleetTrackingDBDataSet)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabVehicleStat.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabVehicleStat;
        private System.Windows.Forms.TabPage tabServiceAppoint;
        private System.Windows.Forms.TabPage tabServiceRequire;
        private System.Windows.Forms.TabPage tabVehicleServiceCompleted;
        private System.Windows.Forms.TabPage tabDetailedServiceInfo;
        private System.Windows.Forms.TabPage tabPlannedTrip;
        private System.Windows.Forms.TabPage tabCompletedTrip;
        private System.Windows.Forms.TabPage tabTimesheet;
        private Microsoft.Reporting.WinForms.ReportViewer reportV;
        private System.Windows.Forms.BindingSource VehicleBindingSource;
        private FleetTrackingDBDataSet FleetTrackingDBDataSet;
        private FleetTrackingDBDataSetTableAdapters.VehicleTableAdapter VehicleTableAdapter;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}