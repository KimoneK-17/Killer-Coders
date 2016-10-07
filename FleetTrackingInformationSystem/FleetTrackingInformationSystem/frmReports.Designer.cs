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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.VehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabVehicleStat = new System.Windows.Forms.TabPage();
            this.dgvVehicleStatus = new System.Windows.Forms.DataGridView();
            this.tabServiceAppoint = new System.Windows.Forms.TabPage();
            this.dgvServiceAppointment = new System.Windows.Forms.DataGridView();
            this.tabServiceRequire = new System.Windows.Forms.TabPage();
            this.dgvServiceReq = new System.Windows.Forms.DataGridView();
            this.tabVehicleServiceCompleted = new System.Windows.Forms.TabPage();
            this.dgvVehicleServices = new System.Windows.Forms.DataGridView();
            this.tabDetailedServiceInfo = new System.Windows.Forms.TabPage();
            this.dgvDetailedService = new System.Windows.Forms.DataGridView();
            this.tabPlannedTrip = new System.Windows.Forms.TabPage();
            this.dgvPlannedTrip = new System.Windows.Forms.DataGridView();
            this.tabCompletedTrip = new System.Windows.Forms.TabPage();
            this.dgvCompletedTrip = new System.Windows.Forms.DataGridView();
            this.tabTimesheet = new System.Windows.Forms.TabPage();
            this.dgvTimeSheet = new System.Windows.Forms.DataGridView();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).BeginInit();
            this.tabReports.SuspendLayout();
            this.tabVehicleStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleStatus)).BeginInit();
            this.tabServiceAppoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceAppointment)).BeginInit();
            this.tabServiceRequire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceReq)).BeginInit();
            this.tabVehicleServiceCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleServices)).BeginInit();
            this.tabDetailedServiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailedService)).BeginInit();
            this.tabPlannedTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlannedTrip)).BeginInit();
            this.tabCompletedTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedTrip)).BeginInit();
            this.tabTimesheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheet)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.SuspendLayout();
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
            this.tabVehicleStat.Controls.Add(this.dgvVehicleStatus);
            this.tabVehicleStat.Location = new System.Drawing.Point(4, 22);
            this.tabVehicleStat.Name = "tabVehicleStat";
            this.tabVehicleStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleStat.Size = new System.Drawing.Size(1015, 446);
            this.tabVehicleStat.TabIndex = 0;
            this.tabVehicleStat.Text = "Vehicle Status Report";
            this.tabVehicleStat.UseVisualStyleBackColor = true;
            // 
            // dgvVehicleStatus
            // 
            this.dgvVehicleStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleStatus.Location = new System.Drawing.Point(0, 3);
            this.dgvVehicleStatus.Name = "dgvVehicleStatus";
            this.dgvVehicleStatus.Size = new System.Drawing.Size(1015, 479);
            this.dgvVehicleStatus.TabIndex = 0;
            this.dgvVehicleStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleStatus_CellContentClick);
            // 
            // tabServiceAppoint
            // 
            this.tabServiceAppoint.Controls.Add(this.dgvServiceAppointment);
            this.tabServiceAppoint.Location = new System.Drawing.Point(4, 22);
            this.tabServiceAppoint.Name = "tabServiceAppoint";
            this.tabServiceAppoint.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceAppoint.Size = new System.Drawing.Size(1015, 446);
            this.tabServiceAppoint.TabIndex = 1;
            this.tabServiceAppoint.Text = "Service Appointment list";
            this.tabServiceAppoint.UseVisualStyleBackColor = true;
            // 
            // dgvServiceAppointment
            // 
            this.dgvServiceAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceAppointment.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceAppointment.Name = "dgvServiceAppointment";
            this.dgvServiceAppointment.Size = new System.Drawing.Size(1019, 483);
            this.dgvServiceAppointment.TabIndex = 0;
            // 
            // tabServiceRequire
            // 
            this.tabServiceRequire.Controls.Add(this.dgvServiceReq);
            this.tabServiceRequire.Location = new System.Drawing.Point(4, 22);
            this.tabServiceRequire.Name = "tabServiceRequire";
            this.tabServiceRequire.Size = new System.Drawing.Size(1015, 446);
            this.tabServiceRequire.TabIndex = 2;
            this.tabServiceRequire.Text = "Service Requirement Job Sheet";
            this.tabServiceRequire.UseVisualStyleBackColor = true;
            // 
            // dgvServiceReq
            // 
            this.dgvServiceReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceReq.Location = new System.Drawing.Point(-4, 0);
            this.dgvServiceReq.Name = "dgvServiceReq";
            this.dgvServiceReq.Size = new System.Drawing.Size(1023, 450);
            this.dgvServiceReq.TabIndex = 0;
            // 
            // tabVehicleServiceCompleted
            // 
            this.tabVehicleServiceCompleted.Controls.Add(this.dgvVehicleServices);
            this.tabVehicleServiceCompleted.Location = new System.Drawing.Point(4, 22);
            this.tabVehicleServiceCompleted.Name = "tabVehicleServiceCompleted";
            this.tabVehicleServiceCompleted.Size = new System.Drawing.Size(1015, 446);
            this.tabVehicleServiceCompleted.TabIndex = 3;
            this.tabVehicleServiceCompleted.Text = "Vehicle Services Completed";
            this.tabVehicleServiceCompleted.UseVisualStyleBackColor = true;
            // 
            // dgvVehicleServices
            // 
            this.dgvVehicleServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleServices.Location = new System.Drawing.Point(-4, 0);
            this.dgvVehicleServices.Name = "dgvVehicleServices";
            this.dgvVehicleServices.Size = new System.Drawing.Size(1023, 533);
            this.dgvVehicleServices.TabIndex = 0;
            // 
            // tabDetailedServiceInfo
            // 
            this.tabDetailedServiceInfo.Controls.Add(this.dgvDetailedService);
            this.tabDetailedServiceInfo.Location = new System.Drawing.Point(4, 22);
            this.tabDetailedServiceInfo.Name = "tabDetailedServiceInfo";
            this.tabDetailedServiceInfo.Size = new System.Drawing.Size(1015, 446);
            this.tabDetailedServiceInfo.TabIndex = 4;
            this.tabDetailedServiceInfo.Text = "Detailed Service Information";
            this.tabDetailedServiceInfo.UseVisualStyleBackColor = true;
            // 
            // dgvDetailedService
            // 
            this.dgvDetailedService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailedService.Location = new System.Drawing.Point(0, 0);
            this.dgvDetailedService.Name = "dgvDetailedService";
            this.dgvDetailedService.Size = new System.Drawing.Size(1019, 493);
            this.dgvDetailedService.TabIndex = 0;
            // 
            // tabPlannedTrip
            // 
            this.tabPlannedTrip.Controls.Add(this.dgvPlannedTrip);
            this.tabPlannedTrip.Location = new System.Drawing.Point(4, 22);
            this.tabPlannedTrip.Name = "tabPlannedTrip";
            this.tabPlannedTrip.Size = new System.Drawing.Size(1015, 446);
            this.tabPlannedTrip.TabIndex = 5;
            this.tabPlannedTrip.Text = "Planned Trip Report";
            this.tabPlannedTrip.UseVisualStyleBackColor = true;
            // 
            // dgvPlannedTrip
            // 
            this.dgvPlannedTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlannedTrip.Location = new System.Drawing.Point(-4, 0);
            this.dgvPlannedTrip.Name = "dgvPlannedTrip";
            this.dgvPlannedTrip.Size = new System.Drawing.Size(1032, 483);
            this.dgvPlannedTrip.TabIndex = 0;
            // 
            // tabCompletedTrip
            // 
            this.tabCompletedTrip.Controls.Add(this.dgvCompletedTrip);
            this.tabCompletedTrip.Location = new System.Drawing.Point(4, 22);
            this.tabCompletedTrip.Name = "tabCompletedTrip";
            this.tabCompletedTrip.Size = new System.Drawing.Size(1015, 446);
            this.tabCompletedTrip.TabIndex = 6;
            this.tabCompletedTrip.Text = "Completed Trip Report";
            this.tabCompletedTrip.UseVisualStyleBackColor = true;
            // 
            // dgvCompletedTrip
            // 
            this.dgvCompletedTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletedTrip.Location = new System.Drawing.Point(-4, 0);
            this.dgvCompletedTrip.Name = "dgvCompletedTrip";
            this.dgvCompletedTrip.Size = new System.Drawing.Size(1016, 517);
            this.dgvCompletedTrip.TabIndex = 0;
            // 
            // tabTimesheet
            // 
            this.tabTimesheet.Controls.Add(this.dgvTimeSheet);
            this.tabTimesheet.Location = new System.Drawing.Point(4, 22);
            this.tabTimesheet.Name = "tabTimesheet";
            this.tabTimesheet.Size = new System.Drawing.Size(1015, 446);
            this.tabTimesheet.TabIndex = 7;
            this.tabTimesheet.Text = "Time Sheet Report";
            this.tabTimesheet.UseVisualStyleBackColor = true;
            // 
            // dgvTimeSheet
            // 
            this.dgvTimeSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeSheet.Location = new System.Drawing.Point(-4, 0);
            this.dgvTimeSheet.Name = "dgvTimeSheet";
            this.dgvTimeSheet.Size = new System.Drawing.Size(1045, 496);
            this.dgvTimeSheet.TabIndex = 0;
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
            this.mnuFleet.Size = new System.Drawing.Size(1163, 24);
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
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1163, 689);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.tabReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabVehicleStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleStatus)).EndInit();
            this.tabServiceAppoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceAppointment)).EndInit();
            this.tabServiceRequire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceReq)).EndInit();
            this.tabVehicleServiceCompleted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleServices)).EndInit();
            this.tabDetailedServiceInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailedService)).EndInit();
            this.tabPlannedTrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlannedTrip)).EndInit();
            this.tabCompletedTrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedTrip)).EndInit();
            this.tabTimesheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheet)).EndInit();
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
        private System.Windows.Forms.BindingSource VehicleBindingSource;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataGridView dgvVehicleStatus;
        private System.Windows.Forms.DataGridView dgvServiceAppointment;
        private System.Windows.Forms.DataGridView dgvServiceReq;
        private System.Windows.Forms.DataGridView dgvVehicleServices;
        private System.Windows.Forms.DataGridView dgvDetailedService;
        private System.Windows.Forms.DataGridView dgvPlannedTrip;
        private System.Windows.Forms.DataGridView dgvCompletedTrip;
        private System.Windows.Forms.DataGridView dgvTimeSheet;
    }
}