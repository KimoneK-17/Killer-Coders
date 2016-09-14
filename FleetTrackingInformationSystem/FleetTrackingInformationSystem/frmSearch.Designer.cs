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
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabCust = new System.Windows.Forms.TabPage();
            this.lbl = new System.Windows.Forms.Label();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.tabTripUsage = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.tabService = new System.Windows.Forms.TabPage();
            this.pnlCustomer.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCustomer.Controls.Add(this.lblSearch);
            this.pnlCustomer.Location = new System.Drawing.Point(54, 45);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(577, 89);
            this.pnlCustomer.TabIndex = 11;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(233, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 33);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(692, 24);
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
            this.mnuBack.Size = new System.Drawing.Size(152, 22);
            this.mnuBack.Text = "Back";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.tabCust);
            this.tabSearch.Controls.Add(this.tabTripUsage);
            this.tabSearch.Controls.Add(this.tabEmployee);
            this.tabSearch.Controls.Add(this.tabLocation);
            this.tabSearch.Controls.Add(this.tabVehicle);
            this.tabSearch.Controls.Add(this.tabService);
            this.tabSearch.Location = new System.Drawing.Point(54, 178);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.Size = new System.Drawing.Size(577, 376);
            this.tabSearch.TabIndex = 16;
            // 
            // tabCust
            // 
            this.tabCust.Controls.Add(this.lbl);
            this.tabCust.Controls.Add(this.cbo1);
            this.tabCust.Controls.Add(this.dGV1);
            this.tabCust.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCust.Location = new System.Drawing.Point(4, 22);
            this.tabCust.Name = "tabCust";
            this.tabCust.Padding = new System.Windows.Forms.Padding(3);
            this.tabCust.Size = new System.Drawing.Size(569, 350);
            this.tabCust.TabIndex = 0;
            this.tabCust.Text = "Customer";
            this.tabCust.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(22, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 18);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "label1";
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(134, 34);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 26);
            this.cbo1.TabIndex = 1;
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(25, 184);
            this.dGV1.Name = "dGV1";
            this.dGV1.Size = new System.Drawing.Size(509, 150);
            this.dGV1.TabIndex = 0;
            // 
            // tabTripUsage
            // 
            this.tabTripUsage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTripUsage.Location = new System.Drawing.Point(4, 22);
            this.tabTripUsage.Name = "tabTripUsage";
            this.tabTripUsage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTripUsage.Size = new System.Drawing.Size(569, 350);
            this.tabTripUsage.TabIndex = 1;
            this.tabTripUsage.Text = "TripUsage";
            this.tabTripUsage.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(569, 350);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabLocation
            // 
            this.tabLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.Location = new System.Drawing.Point(4, 22);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(569, 350);
            this.tabLocation.TabIndex = 3;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // tabVehicle
            // 
            this.tabVehicle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Size = new System.Drawing.Size(569, 350);
            this.tabVehicle.TabIndex = 4;
            this.tabVehicle.Text = "Vehicle";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // tabService
            // 
            this.tabService.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(569, 350);
            this.tabService.TabIndex = 5;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 621);
            this.Controls.Add(this.tabSearch);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Search";
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabCust.ResumeLayout(false);
            this.tabCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tabCust;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.TabPage tabTripUsage;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.TabPage tabService;
    }
}