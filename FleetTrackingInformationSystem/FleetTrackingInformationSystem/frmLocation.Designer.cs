namespace FleetTrackingInformationSystem
{
    partial class frmLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocation));
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblNoOfVehicles = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.cboLocationName = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.updEmployees = new System.Windows.Forms.NumericUpDown();
            this.updVehicles = new System.Windows.Forms.NumericUpDown();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlLocation.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updVehicles)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLocation
            // 
            this.pnlLocation.BackColor = System.Drawing.Color.Transparent;
            this.pnlLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLocation.Controls.Add(this.lblLocation);
            this.pnlLocation.Location = new System.Drawing.Point(12, 58);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(526, 66);
            this.pnlLocation.TabIndex = 9;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLocation.Location = new System.Drawing.Point(201, 16);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(110, 33);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(558, 24);
            this.mnuFleet.TabIndex = 13;
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
            this.mnuBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(99, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocationName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLocationName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLocationName.Location = new System.Drawing.Point(82, 187);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(117, 21);
            this.lblLocationName.TabIndex = 17;
            this.lblLocationName.Text = "Location Name:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCity.Location = new System.Drawing.Point(82, 291);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 21);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.BackColor = System.Drawing.Color.Transparent;
            this.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProvince.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblProvince.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProvince.Location = new System.Drawing.Point(82, 347);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(75, 21);
            this.lblProvince.TabIndex = 20;
            this.lblProvince.Text = "Province:";
            // 
            // lblNoOfVehicles
            // 
            this.lblNoOfVehicles.AutoSize = true;
            this.lblNoOfVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblNoOfVehicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoOfVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNoOfVehicles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfVehicles.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNoOfVehicles.Location = new System.Drawing.Point(82, 398);
            this.lblNoOfVehicles.Name = "lblNoOfVehicles";
            this.lblNoOfVehicles.Size = new System.Drawing.Size(147, 21);
            this.lblNoOfVehicles.TabIndex = 21;
            this.lblNoOfVehicles.Text = "Number of Vehicles:";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmployees.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployees.Location = new System.Drawing.Point(82, 452);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(166, 21);
            this.lblEmployees.TabIndex = 22;
            this.lblEmployees.Text = "Number of Employees:";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.BackColor = System.Drawing.Color.Transparent;
            this.lblManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblManager.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblManager.Location = new System.Drawing.Point(82, 507);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(144, 21);
            this.lblManager.TabIndex = 23;
            this.lblManager.Text = "Manager In Charge:";
            // 
            // txtManager
            // 
            this.txtManager.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManager.Location = new System.Drawing.Point(252, 500);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(180, 26);
            this.txtManager.TabIndex = 29;
            // 
            // cboLocationName
            // 
            this.cboLocationName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocationName.FormattingEnabled = true;
            this.cboLocationName.Location = new System.Drawing.Point(252, 180);
            this.cboLocationName.Name = "cboLocationName";
            this.cboLocationName.Size = new System.Drawing.Size(180, 26);
            this.cboLocationName.TabIndex = 30;
            this.cboLocationName.SelectedIndexChanged += new System.EventHandler(this.cboLocationName_SelectedIndexChanged);
            // 
            // cboCity
            // 
            this.cboCity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "Durban",
            "Johnessburg",
            "Cape Town",
            "Pretoria",
            "Port Elizabeth",
            "Bloemfontein",
            "Pietermaritzburg",
            "East London",
            "Polokwane",
            "Nelspruit",
            "Kimberly",
            "Soweto",
            "Rustenburg",
            "Benoni",
            "Richards bay",
            "Umhlazi"});
            this.cboCity.Location = new System.Drawing.Point(252, 284);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(180, 26);
            this.cboCity.TabIndex = 31;
            // 
            // cboProvince
            // 
            this.cboProvince.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "The Eastern Cape.",
            "The Free State.",
            "Gauteng.",
            "KwaZulu-Natal.",
            "Limpopo.",
            "Mpumalanga.",
            "The Northern Cape.",
            "North West.",
            "Western Cape."});
            this.cboProvince.Location = new System.Drawing.Point(252, 340);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(180, 26);
            this.cboProvince.TabIndex = 32;
            // 
            // updEmployees
            // 
            this.updEmployees.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updEmployees.Location = new System.Drawing.Point(252, 445);
            this.updEmployees.Name = "updEmployees";
            this.updEmployees.Size = new System.Drawing.Size(180, 26);
            this.updEmployees.TabIndex = 33;
            // 
            // updVehicles
            // 
            this.updVehicles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updVehicles.Location = new System.Drawing.Point(252, 391);
            this.updVehicles.Name = "updVehicles";
            this.updVehicles.Size = new System.Drawing.Size(180, 26);
            this.updVehicles.TabIndex = 34;
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocationID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLocationID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLocationID.Location = new System.Drawing.Point(82, 241);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(91, 21);
            this.lblLocationID.TabIndex = 35;
            this.lblLocationID.Text = "Location ID:";
            // 
            // txtLocationID
            // 
            this.txtLocationID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationID.Location = new System.Drawing.Point(252, 234);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.Size = new System.Drawing.Size(180, 26);
            this.txtLocationID.TabIndex = 36;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(368, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(156, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(50, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(262, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Location = new System.Drawing.Point(12, 565);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(526, 66);
            this.pnlButtons.TabIndex = 38;
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(558, 688);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtLocationID);
            this.Controls.Add(this.lblLocationID);
            this.Controls.Add(this.updVehicles);
            this.Controls.Add(this.updEmployees);
            this.Controls.Add(this.cboProvince);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.cboLocationName);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.lblNoOfVehicles);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Tracking Information System";
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updVehicles)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblNoOfVehicles;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.ComboBox cboLocationName;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.NumericUpDown updEmployees;
        private System.Windows.Forms.NumericUpDown updVehicles;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlButtons;
    }
}