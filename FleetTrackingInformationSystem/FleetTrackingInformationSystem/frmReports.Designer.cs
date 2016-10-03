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
            this.FleetTrackingDBDataSet = new FleetTrackingInformationSystem.FleetTrackingDBDataSet();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabVehicleStat = new System.Windows.Forms.TabPage();
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
            this.dgvVehicleStatus = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FleetTrackingDBDataSet)).BeginInit();
            this.tabReports.SuspendLayout();
            this.tabVehicleStat.SuspendLayout();
            this.tabServiceAppoint.SuspendLayout();
            this.tabServiceRequire.SuspendLayout();
            this.tabVehicleServiceCompleted.SuspendLayout();
            this.tabDetailedServiceInfo.SuspendLayout();
            this.tabPlannedTrip.SuspendLayout();
            this.tabCompletedTrip.SuspendLayout();
            this.tabTimesheet.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
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
            this.tabVehicleStat.Controls.Add(this.dgvVehicleStatus);
            this.tabVehicleStat.Location = new System.Drawing.Point(4, 22);
            this.tabVehicleStat.Name = "tabVehicleStat";
            this.tabVehicleStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleStat.Size = new System.Drawing.Size(1015, 446);
            this.tabVehicleStat.TabIndex = 0;
            this.tabVehicleStat.Text = "Vehicle Status Report";
            this.tabVehicleStat.UseVisualStyleBackColor = true;
            // 
            // tabServiceAppoint
            // 
            this.tabServiceAppoint.Controls.Add(this.dataGridView2);
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
            this.tabServiceRequire.Controls.Add(this.dataGridView3);
            this.tabServiceRequire.Location = new System.Drawing.Point(4, 22);
            this.tabServiceRequire.Name = "tabServiceRequire";
            this.tabServiceRequire.Size = new System.Drawing.Size(1015, 446);
            this.tabServiceRequire.TabIndex = 2;
            this.tabServiceRequire.Text = "Service Requirement Job Sheet";
            this.tabServiceRequire.UseVisualStyleBackColor = true;
            // 
            // tabVehicleServiceCompleted
            // 
            this.tabVehicleServiceCompleted.Controls.Add(this.dataGridView4);
            this.tabVehicleServiceCompleted.Location = new System.Drawing.Point(4, 22);
            this.tabVehicleServiceCompleted.Name = "tabVehicleServiceCompleted";
            this.tabVehicleServiceCompleted.Size = new System.Drawing.Size(1015, 446);
            this.tabVehicleServiceCompleted.TabIndex = 3;
            this.tabVehicleServiceCompleted.Text = "Vehicle Services Completed";
            this.tabVehicleServiceCompleted.UseVisualStyleBackColor = true;
            // 
            // tabDetailedServiceInfo
            // 
            this.tabDetailedServiceInfo.Controls.Add(this.dataGridView5);
            this.tabDetailedServiceInfo.Location = new System.Drawing.Point(4, 22);
            this.tabDetailedServiceInfo.Name = "tabDetailedServiceInfo";
            this.tabDetailedServiceInfo.Size = new System.Drawing.Size(1015, 446);
            this.tabDetailedServiceInfo.TabIndex = 4;
            this.tabDetailedServiceInfo.Text = "Detailed Service Information";
            this.tabDetailedServiceInfo.UseVisualStyleBackColor = true;
            // 
            // tabPlannedTrip
            // 
            this.tabPlannedTrip.Controls.Add(this.dataGridView6);
            this.tabPlannedTrip.Location = new System.Drawing.Point(4, 22);
            this.tabPlannedTrip.Name = "tabPlannedTrip";
            this.tabPlannedTrip.Size = new System.Drawing.Size(1015, 446);
            this.tabPlannedTrip.TabIndex = 5;
            this.tabPlannedTrip.Text = "Planned Trip Report";
            this.tabPlannedTrip.UseVisualStyleBackColor = true;
            // 
            // tabCompletedTrip
            // 
            this.tabCompletedTrip.Controls.Add(this.dataGridView7);
            this.tabCompletedTrip.Location = new System.Drawing.Point(4, 22);
            this.tabCompletedTrip.Name = "tabCompletedTrip";
            this.tabCompletedTrip.Size = new System.Drawing.Size(1015, 446);
            this.tabCompletedTrip.TabIndex = 6;
            this.tabCompletedTrip.Text = "Completed Trip Report";
            this.tabCompletedTrip.UseVisualStyleBackColor = true;
            // 
            // tabTimesheet
            // 
            this.tabTimesheet.Controls.Add(this.dataGridView8);
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
            // dgvVehicleStatus
            // 
            this.dgvVehicleStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleStatus.Location = new System.Drawing.Point(0, 3);
            this.dgvVehicleStatus.Name = "dgvVehicleStatus";
            this.dgvVehicleStatus.Size = new System.Drawing.Size(1015, 479);
            this.dgvVehicleStatus.TabIndex = 0;
            this.dgvVehicleStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1019, 483);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1023, 450);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1023, 533);
            this.dataGridView4.TabIndex = 0;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1019, 493);
            this.dataGridView5.TabIndex = 0;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(1032, 483);
            this.dataGridView6.TabIndex = 0;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(1016, 517);
            this.dataGridView7.TabIndex = 0;
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(1045, 496);
            this.dataGridView8.TabIndex = 0;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FleetTrackingDBDataSet)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabVehicleStat.ResumeLayout(false);
            this.tabServiceAppoint.ResumeLayout(false);
            this.tabServiceRequire.ResumeLayout(false);
            this.tabVehicleServiceCompleted.ResumeLayout(false);
            this.tabDetailedServiceInfo.ResumeLayout(false);
            this.tabPlannedTrip.ResumeLayout(false);
            this.tabCompletedTrip.ResumeLayout(false);
            this.tabTimesheet.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
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
        private FleetTrackingDBDataSet FleetTrackingDBDataSet;
        private FleetTrackingDBDataSetTableAdapters.VehicleTableAdapter VehicleTableAdapter;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataGridView dgvVehicleStatus;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridView dataGridView8;
    }
}