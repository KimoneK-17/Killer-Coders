namespace FleetTrackingInformationSystem
{
    partial class frmScheduling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduling));
            this.pnlScheduling = new System.Windows.Forms.Panel();
            this.lblScheduling = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblNumHoursWorked = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.updHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlScheduling.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHoursWorked)).BeginInit();
            this.pnlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScheduling
            // 
            this.pnlScheduling.BackColor = System.Drawing.Color.Transparent;
            this.pnlScheduling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlScheduling.Controls.Add(this.lblScheduling);
            this.pnlScheduling.Location = new System.Drawing.Point(29, 54);
            this.pnlScheduling.Name = "pnlScheduling";
            this.pnlScheduling.Size = new System.Drawing.Size(523, 89);
            this.pnlScheduling.TabIndex = 9;
            // 
            // lblScheduling
            // 
            this.lblScheduling.AutoSize = true;
            this.lblScheduling.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduling.Location = new System.Drawing.Point(195, 23);
            this.lblScheduling.Name = "lblScheduling";
            this.lblScheduling.Size = new System.Drawing.Size(136, 33);
            this.lblScheduling.TabIndex = 7;
            this.lblScheduling.Text = "Scheduling";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(577, 24);
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
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmployeeID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(38, 170);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(98, 19);
            this.lblEmployeeID.TabIndex = 17;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblNumHoursWorked
            // 
            this.lblNumHoursWorked.AutoSize = true;
            this.lblNumHoursWorked.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNumHoursWorked.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHoursWorked.Location = new System.Drawing.Point(38, 225);
            this.lblNumHoursWorked.Name = "lblNumHoursWorked";
            this.lblNumHoursWorked.Size = new System.Drawing.Size(191, 19);
            this.lblNumHoursWorked.TabIndex = 18;
            this.lblNumHoursWorked.Text = "Number Of Hours Worked:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(38, 285);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(244, 163);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(234, 26);
            this.txtEmployeeID.TabIndex = 20;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(244, 278);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(234, 26);
            this.dtpDate.TabIndex = 21;
            // 
            // updHoursWorked
            // 
            this.updHoursWorked.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updHoursWorked.Location = new System.Drawing.Point(244, 218);
            this.updHoursWorked.Name = "updHoursWorked";
            this.updHoursWorked.Size = new System.Drawing.Size(234, 26);
            this.updHoursWorked.TabIndex = 35;
            // 
            // pnlBtns
            // 
            this.pnlBtns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtns.Controls.Add(this.btnSearch);
            this.pnlBtns.Controls.Add(this.btnDelete);
            this.pnlBtns.Controls.Add(this.btnSubmit);
            this.pnlBtns.Controls.Add(this.btnReset);
            this.pnlBtns.Location = new System.Drawing.Point(29, 349);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(523, 64);
            this.pnlBtns.TabIndex = 36;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(32, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 35);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(131, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(292, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 35);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(395, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 35);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 447);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.updHoursWorked);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumHoursWorked);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlScheduling);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScheduling";
            this.Text = "Fleet Tracking Information System";
            this.pnlScheduling.ResumeLayout(false);
            this.pnlScheduling.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHoursWorked)).EndInit();
            this.pnlBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlScheduling;
        private System.Windows.Forms.Label lblScheduling;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblNumHoursWorked;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown updHoursWorked;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
    }
}