namespace FleetTrackingInformationSystem
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTrip = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnScheduling = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTrip = new System.Windows.Forms.Panel();
            this.pnlService = new System.Windows.Forms.Panel();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.pnlTrip.SuspendLayout();
            this.pnlService.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.pnlVehicle.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenu.Location = new System.Drawing.Point(206, 30);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(95, 39);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(27, 56);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(507, 100);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnVehicle
            // 
            this.btnVehicle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVehicle.Location = new System.Drawing.Point(15, 23);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(100, 31);
            this.btnVehicle.TabIndex = 2;
            this.btnVehicle.Text = "Vehicles";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReports.Location = new System.Drawing.Point(14, 21);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(100, 31);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTrip
            // 
            this.btnTrip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTrip.Location = new System.Drawing.Point(19, 23);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(100, 31);
            this.btnTrip.TabIndex = 4;
            this.btnTrip.Text = "Trip / Usage";
            this.btnTrip.UseVisualStyleBackColor = true;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // btnService
            // 
            this.btnService.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnService.Location = new System.Drawing.Point(15, 22);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(100, 31);
            this.btnService.TabIndex = 5;
            this.btnService.Text = "Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnScheduling
            // 
            this.btnScheduling.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduling.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnScheduling.Location = new System.Drawing.Point(16, 22);
            this.btnScheduling.Name = "btnScheduling";
            this.btnScheduling.Size = new System.Drawing.Size(100, 31);
            this.btnScheduling.TabIndex = 6;
            this.btnScheduling.Text = "Scheduling";
            this.btnScheduling.UseVisualStyleBackColor = true;
            this.btnScheduling.Click += new System.EventHandler(this.btnScheduling_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLocation.Location = new System.Drawing.Point(15, 21);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(100, 31);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.Text = "Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCustomer.Location = new System.Drawing.Point(18, 21);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(100, 31);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(565, 24);
            this.mnuFleet.TabIndex = 10;
            this.mnuFleet.Text = "menuStrip1";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogOut,
            this.mnuExit});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.Size = new System.Drawing.Size(112, 22);
            this.mnuLogOut.Text = "Logout";
            this.mnuLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(112, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTrip
            // 
            this.pnlTrip.BackColor = System.Drawing.Color.Transparent;
            this.pnlTrip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTrip.Controls.Add(this.btnTrip);
            this.pnlTrip.Location = new System.Drawing.Point(27, 187);
            this.pnlTrip.Name = "pnlTrip";
            this.pnlTrip.Size = new System.Drawing.Size(138, 79);
            this.pnlTrip.TabIndex = 11;
            // 
            // pnlService
            // 
            this.pnlService.BackColor = System.Drawing.Color.Transparent;
            this.pnlService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlService.Controls.Add(this.btnService);
            this.pnlService.Location = new System.Drawing.Point(213, 187);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(138, 79);
            this.pnlService.TabIndex = 12;
            // 
            // pnlLocation
            // 
            this.pnlLocation.BackColor = System.Drawing.Color.Transparent;
            this.pnlLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLocation.Controls.Add(this.btnLocation);
            this.pnlLocation.Location = new System.Drawing.Point(213, 419);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(138, 79);
            this.pnlLocation.TabIndex = 13;
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.Transparent;
            this.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTime.Controls.Add(this.btnScheduling);
            this.pnlTime.Location = new System.Drawing.Point(27, 305);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(138, 79);
            this.pnlTime.TabIndex = 14;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCustomer.Controls.Add(this.btnCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(391, 305);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(138, 79);
            this.pnlCustomer.TabIndex = 15;
            // 
            // pnlReport
            // 
            this.pnlReport.BackColor = System.Drawing.Color.Transparent;
            this.pnlReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReport.Controls.Add(this.btnReports);
            this.pnlReport.Location = new System.Drawing.Point(391, 187);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(138, 79);
            this.pnlReport.TabIndex = 16;
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.BackColor = System.Drawing.Color.Transparent;
            this.pnlVehicle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVehicle.Controls.Add(this.btnVehicle);
            this.pnlVehicle.Location = new System.Drawing.Point(27, 419);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(138, 79);
            this.pnlVehicle.TabIndex = 17;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEmployee.Controls.Add(this.btnEmployee);
            this.pnlEmployee.Location = new System.Drawing.Point(391, 419);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(138, 79);
            this.pnlEmployee.TabIndex = 18;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployee.Location = new System.Drawing.Point(15, 23);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(100, 31);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Location = new System.Drawing.Point(213, 305);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(138, 79);
            this.pnlSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Location = new System.Drawing.Point(15, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(565, 537);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.pnlVehicle);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.pnlTrip);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Tracking Information System";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.pnlTrip.ResumeLayout(false);
            this.pnlService.ResumeLayout(false);
            this.pnlLocation.ResumeLayout(false);
            this.pnlTime.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlReport.ResumeLayout(false);
            this.pnlVehicle.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTrip;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnScheduling;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.Panel pnlTrip;
        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}