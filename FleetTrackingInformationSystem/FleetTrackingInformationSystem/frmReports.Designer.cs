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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleStatusReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServiceAppList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServiceReqJobSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecificService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlannedTripReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompletedTrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimesheet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwReports = new System.Windows.Forms.ListView();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFleet.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(854, 24);
            this.mnuFleet.TabIndex = 13;
            this.mnuFleet.Text = "menuStrip1";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleStatusReport,
            this.mnuServiceAppList,
            this.mnuServiceReqJobSheet,
            this.mnuVehicleService,
            this.mnuSpecificService,
            this.mnuPlannedTripReport,
            this.mnuCompletedTrip,
            this.mnuTimesheet,
            this.toolStripSeparator1,
            this.mnuPrint,
            this.mnuBack,
            this.mnuExit});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuVehicleStatusReport
            // 
            this.mnuVehicleStatusReport.Name = "mnuVehicleStatusReport";
            this.mnuVehicleStatusReport.Size = new System.Drawing.Size(244, 22);
            this.mnuVehicleStatusReport.Text = "Vehicle Status Report";
            // 
            // mnuServiceAppList
            // 
            this.mnuServiceAppList.Name = "mnuServiceAppList";
            this.mnuServiceAppList.Size = new System.Drawing.Size(244, 22);
            this.mnuServiceAppList.Text = "Service Appointment List Report";
            // 
            // mnuServiceReqJobSheet
            // 
            this.mnuServiceReqJobSheet.Name = "mnuServiceReqJobSheet";
            this.mnuServiceReqJobSheet.Size = new System.Drawing.Size(244, 22);
            this.mnuServiceReqJobSheet.Text = "Service Requirments Job Sheet";
            // 
            // mnuVehicleService
            // 
            this.mnuVehicleService.Name = "mnuVehicleService";
            this.mnuVehicleService.Size = new System.Drawing.Size(244, 22);
            this.mnuVehicleService.Text = "Vehicle Service Report";
            // 
            // mnuSpecificService
            // 
            this.mnuSpecificService.Name = "mnuSpecificService";
            this.mnuSpecificService.Size = new System.Drawing.Size(244, 22);
            this.mnuSpecificService.Text = "Specific Service Report";
            // 
            // mnuPlannedTripReport
            // 
            this.mnuPlannedTripReport.Name = "mnuPlannedTripReport";
            this.mnuPlannedTripReport.Size = new System.Drawing.Size(244, 22);
            this.mnuPlannedTripReport.Text = "Planned Trip Report";
            // 
            // mnuCompletedTrip
            // 
            this.mnuCompletedTrip.Name = "mnuCompletedTrip";
            this.mnuCompletedTrip.Size = new System.Drawing.Size(244, 22);
            this.mnuCompletedTrip.Text = "Completed Trip Report";
            // 
            // mnuTimesheet
            // 
            this.mnuTimesheet.Name = "mnuTimesheet";
            this.mnuTimesheet.Size = new System.Drawing.Size(244, 22);
            this.mnuTimesheet.Text = "Timesheet Report";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(244, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(244, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvwReports
            // 
            this.lvwReports.Location = new System.Drawing.Point(0, 27);
            this.lvwReports.Name = "lvwReports";
            this.lvwReports.Size = new System.Drawing.Size(854, 482);
            this.lvwReports.TabIndex = 14;
            this.lvwReports.UseCompatibleStateImageBehavior = false;
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(244, 22);
            this.mnuPrint.Text = "Print";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 515);
            this.Controls.Add(this.lvwReports);
            this.Controls.Add(this.mnuFleet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleStatusReport;
        private System.Windows.Forms.ToolStripMenuItem mnuServiceAppList;
        private System.Windows.Forms.ToolStripMenuItem mnuServiceReqJobSheet;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleService;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecificService;
        private System.Windows.Forms.ToolStripMenuItem mnuPlannedTripReport;
        private System.Windows.Forms.ToolStripMenuItem mnuCompletedTrip;
        private System.Windows.Forms.ToolStripMenuItem mnuTimesheet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListView lvwReports;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
    }
}