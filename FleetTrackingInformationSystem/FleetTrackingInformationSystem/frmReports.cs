using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetTrackingInformationSystem
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes Back to Menu Form
                men.ShowDialog();
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error");
                    this.Hide();
                    frmLogin log = new frmLogin();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmLogin log = new frmLogin();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            lvwReports.View = View.Details;
            lvwReports.Columns.Add("Nothing", 0, HorizontalAlignment.Left);
            lvwReports.View = View.Details;
            lvwReports.Columns.Add("Vehicle Reg Number", 150, HorizontalAlignment.Left);
            lvwReports.View = View.Details;
            lvwReports.Columns.Add("Vehicle Type", 150, HorizontalAlignment.Left);
            lvwReports.View = View.Details;
            lvwReports.Columns.Add("Vehicle Make", 150, HorizontalAlignment.Left);
            lvwReports.View = View.Details;
            lvwReports.Columns.Add("Vehicle Model", 150, HorizontalAlignment.Left);
            lvwReports.View = View.Details;
            lvwReports.Columns.Add("Vehicle Year", 150, HorizontalAlignment.Left);
        }      
    }
}
