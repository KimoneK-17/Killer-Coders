namespace FleetTrackingInformationSystem
{
    partial class frmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.dtpVehicleYear = new System.Windows.Forms.DateTimePicker();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlVehicle.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.BackColor = System.Drawing.Color.Transparent;
            this.pnlVehicle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVehicle.Controls.Add(this.lblVehicle);
            this.pnlVehicle.Location = new System.Drawing.Point(34, 69);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(574, 89);
            this.pnlVehicle.TabIndex = 9;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(218, 25);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(108, 33);
            this.lblVehicle.TabIndex = 7;
            this.lblVehicle.Text = "Vehicles";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(630, 24);
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
            this.mnuBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(99, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(55, 200);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(118, 19);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type Of Vehicle:";
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRegNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNum.Location = new System.Drawing.Point(55, 245);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(155, 19);
            this.lblRegNum.TabIndex = 21;
            this.lblRegNum.Text = "Registration Number:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMileage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileage.Location = new System.Drawing.Point(55, 291);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(119, 19);
            this.lblMileage.TabIndex = 22;
            this.lblMileage.Text = "Vehicle Mileage:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMake.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(55, 341);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(103, 19);
            this.lblMake.TabIndex = 23;
            this.lblMake.Text = "Vehicle Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(55, 390);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(109, 19);
            this.lblModel.TabIndex = 24;
            this.lblModel.Text = "Vehicle Model:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(55, 437);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(94, 19);
            this.lblYear.TabIndex = 25;
            this.lblYear.Text = "Vehicle Year:";
            // 
            // txtRegNum
            // 
            this.txtRegNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNum.Location = new System.Drawing.Point(216, 238);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(234, 26);
            this.txtRegNum.TabIndex = 26;
            // 
            // txtMileage
            // 
            this.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMileage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMileage.Location = new System.Drawing.Point(216, 284);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(234, 26);
            this.txtMileage.TabIndex = 27;
            // 
            // txtMake
            // 
            this.txtMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMake.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(216, 334);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(234, 26);
            this.txtMake.TabIndex = 28;
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(216, 383);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(234, 26);
            this.txtModel.TabIndex = 29;
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(216, 193);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(234, 26);
            this.cboType.TabIndex = 33;
            // 
            // dtpVehicleYear
            // 
            this.dtpVehicleYear.CustomFormat = "yyyy";
            this.dtpVehicleYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVehicleYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVehicleYear.Location = new System.Drawing.Point(216, 432);
            this.dtpVehicleYear.Name = "dtpVehicleYear";
            this.dtpVehicleYear.Size = new System.Drawing.Size(234, 26);
            this.dtpVehicleYear.TabIndex = 34;
            this.dtpVehicleYear.Value = new System.DateTime(2016, 7, 19, 1, 34, 49, 0);
            // 
            // pnlBtns
            // 
            this.pnlBtns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtns.Controls.Add(this.btnSearch);
            this.pnlBtns.Controls.Add(this.btnDelete);
            this.pnlBtns.Controls.Add(this.btnSubmit);
            this.pnlBtns.Controls.Add(this.btnReset);
            this.pnlBtns.Location = new System.Drawing.Point(34, 501);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(574, 64);
            this.pnlBtns.TabIndex = 35;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(31, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 35);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(133, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(356, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 35);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(458, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 35);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 611);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.dtpVehicleYear);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtRegNum);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblRegNum);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlVehicle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVehicles";
            this.Text = "Fleet Tracking Information System";
            this.pnlVehicle.ResumeLayout(false);
            this.pnlVehicle.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DateTimePicker dtpVehicleYear;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
    }
}