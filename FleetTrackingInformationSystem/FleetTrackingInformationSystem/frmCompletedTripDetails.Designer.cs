namespace FleetTrackingInformationSystem
{
    partial class frmCompletedTripDetails
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
            this.txtKM = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtVehicleIncidents = new System.Windows.Forms.TextBox();
            this.lblVehicleIncidents = new System.Windows.Forms.Label();
            this.txtFuelUsage = new System.Windows.Forms.TextBox();
            this.lblFuelUsage = new System.Windows.Forms.Label();
            this.lblTripID = new System.Windows.Forms.Label();
            this.cboT_ID = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKM
            // 
            this.txtKM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKM.Location = new System.Drawing.Point(175, 212);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(197, 26);
            this.txtKM.TabIndex = 24;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.BackColor = System.Drawing.Color.Transparent;
            this.lblKm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblKm.Location = new System.Drawing.Point(11, 219);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(102, 19);
            this.lblKm.TabIndex = 23;
            this.lblKm.Text = "KM Travelled:";
            // 
            // txtVehicleIncidents
            // 
            this.txtVehicleIncidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleIncidents.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleIncidents.Location = new System.Drawing.Point(175, 151);
            this.txtVehicleIncidents.Multiline = true;
            this.txtVehicleIncidents.Name = "txtVehicleIncidents";
            this.txtVehicleIncidents.Size = new System.Drawing.Size(197, 55);
            this.txtVehicleIncidents.TabIndex = 21;
            // 
            // lblVehicleIncidents
            // 
            this.lblVehicleIncidents.AutoSize = true;
            this.lblVehicleIncidents.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleIncidents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVehicleIncidents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleIncidents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleIncidents.Location = new System.Drawing.Point(11, 158);
            this.lblVehicleIncidents.Name = "lblVehicleIncidents";
            this.lblVehicleIncidents.Size = new System.Drawing.Size(127, 19);
            this.lblVehicleIncidents.TabIndex = 20;
            this.lblVehicleIncidents.Text = "Vehicle Incidents:";
            // 
            // txtFuelUsage
            // 
            this.txtFuelUsage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuelUsage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuelUsage.Location = new System.Drawing.Point(175, 95);
            this.txtFuelUsage.Name = "txtFuelUsage";
            this.txtFuelUsage.Size = new System.Drawing.Size(197, 26);
            this.txtFuelUsage.TabIndex = 22;
            // 
            // lblFuelUsage
            // 
            this.lblFuelUsage.AutoSize = true;
            this.lblFuelUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblFuelUsage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFuelUsage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelUsage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFuelUsage.Location = new System.Drawing.Point(11, 102);
            this.lblFuelUsage.Name = "lblFuelUsage";
            this.lblFuelUsage.Size = new System.Drawing.Size(85, 19);
            this.lblFuelUsage.TabIndex = 19;
            this.lblFuelUsage.Text = "Fuel Usage:";
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.BackColor = System.Drawing.Color.Transparent;
            this.lblTripID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTripID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTripID.Location = new System.Drawing.Point(11, 47);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(57, 19);
            this.lblTripID.TabIndex = 25;
            this.lblTripID.Text = "Trip ID:";
            // 
            // cboT_ID
            // 
            this.cboT_ID.FormattingEnabled = true;
            this.cboT_ID.Location = new System.Drawing.Point(175, 47);
            this.cboT_ID.Name = "cboT_ID";
            this.cboT_ID.Size = new System.Drawing.Size(121, 21);
            this.cboT_ID.TabIndex = 26;
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
            this.pnlButtons.Location = new System.Drawing.Point(32, 279);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(530, 64);
            this.pnlButtons.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(404, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(163, 13);
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
            this.btnDelete.Location = new System.Drawing.Point(39, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(290, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmCompletedTripDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 355);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.cboT_ID);
            this.Controls.Add(this.lblTripID);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.txtVehicleIncidents);
            this.Controls.Add(this.lblVehicleIncidents);
            this.Controls.Add(this.txtFuelUsage);
            this.Controls.Add(this.lblFuelUsage);
            this.Name = "frmCompletedTripDetails";
            this.Text = "frmCompletedTripDetails";
            this.Load += new System.EventHandler(this.frmCompletedTripDetails_Load);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtVehicleIncidents;
        private System.Windows.Forms.Label lblVehicleIncidents;
        private System.Windows.Forms.TextBox txtFuelUsage;
        private System.Windows.Forms.Label lblFuelUsage;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.ComboBox cboT_ID;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}