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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabCust = new System.Windows.Forms.TabPage();
            this.tabTripUsage = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.tabService = new System.Windows.Forms.TabPage();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fleetTrackingDBDataSet = new FleetTrackingInformationSystem.FleetTrackingDBDataSet();
            this.customerTableAdapter = new FleetTrackingInformationSystem.FleetTrackingDBDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new FleetTrackingInformationSystem.FleetTrackingDBDataSetTableAdapters.TableAdapterManager();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fleetTrackingDBDataSet1 = new FleetTrackingInformationSystem.FleetTrackingDBDataSet();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPayDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPayMadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTableAdapter1 = new FleetTrackingInformationSystem.FleetTrackingDBDataSetTableAdapters.CustomerTableAdapter();
            this.mnuFleet.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetTrackingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetTrackingDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // tabCust
            // 
            this.tabCust.AutoScroll = true;
            this.tabCust.Controls.Add(this.dataGridView1);
            this.tabCust.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCust.Location = new System.Drawing.Point(4, 22);
            this.tabCust.Name = "tabCust";
            this.tabCust.Padding = new System.Windows.Forms.Padding(3);
            this.tabCust.Size = new System.Drawing.Size(959, 352);
            this.tabCust.TabIndex = 0;
            this.tabCust.Text = "Customer";
            this.tabCust.UseVisualStyleBackColor = true;
            // 
            // tabTripUsage
            // 
            this.tabTripUsage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTripUsage.Location = new System.Drawing.Point(4, 22);
            this.tabTripUsage.Name = "tabTripUsage";
            this.tabTripUsage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTripUsage.Size = new System.Drawing.Size(959, 352);
            this.tabTripUsage.TabIndex = 1;
            this.tabTripUsage.Text = "TripUsage";
            this.tabTripUsage.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(959, 352);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabLocation
            // 
            this.tabLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.Location = new System.Drawing.Point(4, 22);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(959, 352);
            this.tabLocation.TabIndex = 3;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // tabVehicle
            // 
            this.tabVehicle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Size = new System.Drawing.Size(959, 352);
            this.tabVehicle.TabIndex = 4;
            this.tabVehicle.Text = "Vehicle";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // tabService
            // 
            this.tabService.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(959, 352);
            this.tabService.TabIndex = 5;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.fleetTrackingDBDataSet;
            // 
            // fleetTrackingDBDataSet
            // 
            this.fleetTrackingDBDataSet.DataSetName = "FleetTrackingDBDataSet";
            this.fleetTrackingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.RegisterTableAdapter = null;
            this.tableAdapterManager.tblServiceTableAdapter = null;
            this.tableAdapterManager.TripUsageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FleetTrackingInformationSystem.FleetTrackingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.fleetTrackingDBDataSet;
            // 
            // fleetTrackingDBDataSet1
            // 
            this.fleetTrackingDBDataSet1.DataSetName = "FleetTrackingDBDataSet";
            this.fleetTrackingDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.fleetTrackingDBDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.custSurnameDataGridViewTextBoxColumn,
            this.custTypeDataGridViewTextBoxColumn,
            this.custContactNoDataGridViewTextBoxColumn,
            this.custEmailDataGridViewTextBoxColumn,
            this.custPayDueDataGridViewTextBoxColumn,
            this.custPayMadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(203, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_Name";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "Cust_Name";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            // 
            // custSurnameDataGridViewTextBoxColumn
            // 
            this.custSurnameDataGridViewTextBoxColumn.DataPropertyName = "Cust_Surname";
            this.custSurnameDataGridViewTextBoxColumn.HeaderText = "Cust_Surname";
            this.custSurnameDataGridViewTextBoxColumn.Name = "custSurnameDataGridViewTextBoxColumn";
            // 
            // custTypeDataGridViewTextBoxColumn
            // 
            this.custTypeDataGridViewTextBoxColumn.DataPropertyName = "Cust_Type";
            this.custTypeDataGridViewTextBoxColumn.HeaderText = "Cust_Type";
            this.custTypeDataGridViewTextBoxColumn.Name = "custTypeDataGridViewTextBoxColumn";
            // 
            // custContactNoDataGridViewTextBoxColumn
            // 
            this.custContactNoDataGridViewTextBoxColumn.DataPropertyName = "Cust_ContactNo";
            this.custContactNoDataGridViewTextBoxColumn.HeaderText = "Cust_ContactNo";
            this.custContactNoDataGridViewTextBoxColumn.Name = "custContactNoDataGridViewTextBoxColumn";
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "Cust_Email";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "Cust_Email";
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            // 
            // custPayDueDataGridViewTextBoxColumn
            // 
            this.custPayDueDataGridViewTextBoxColumn.DataPropertyName = "Cust_PayDue";
            this.custPayDueDataGridViewTextBoxColumn.HeaderText = "Cust_PayDue";
            this.custPayDueDataGridViewTextBoxColumn.Name = "custPayDueDataGridViewTextBoxColumn";
            // 
            // custPayMadeDataGridViewTextBoxColumn
            // 
            this.custPayMadeDataGridViewTextBoxColumn.DataPropertyName = "Cust_PayMade";
            this.custPayMadeDataGridViewTextBoxColumn.HeaderText = "Cust_PayMade";
            this.custPayMadeDataGridViewTextBoxColumn.Name = "custPayMadeDataGridViewTextBoxColumn";
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
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
            this.tabSearch.ResumeLayout(false);
            this.tabCust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetTrackingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetTrackingDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tabCust;
        private System.Windows.Forms.TabPage tabTripUsage;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.TabPage tabService;
        private FleetTrackingDBDataSet fleetTrackingDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private FleetTrackingDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private FleetTrackingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private FleetTrackingDBDataSet fleetTrackingDBDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPayDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPayMadeDataGridViewTextBoxColumn;
        private FleetTrackingDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
    }
}