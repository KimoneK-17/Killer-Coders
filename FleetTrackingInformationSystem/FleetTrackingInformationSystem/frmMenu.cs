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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmService ser = new frmService(); // Creates an Object 
                ser.ShowDialog(); // Shows the Service Form
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

        private void btnTrip_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmTripUsage tU = new frmTripUsage(); // Creates an Object 
                tU.ShowDialog(); // Shows the Trip and Usage Form
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmReports rp = new frmReports(); // Creates an Object 
                rp.ShowDialog(); // Shows the Report Form
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmReports log = new frmReports();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnScheduling_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmScheduling tS = new frmScheduling(); // Creates an Object 
                tS.ShowDialog(); // Shows the Timesheet Form
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmReports log = new frmReports();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmLocation loc = new frmLocation(); // Creates an Object 
                loc.ShowDialog(); // Shows the Location Form
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmReports log = new frmReports();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmCustomer cus = new frmCustomer(); // Creates an Object 
                cus.ShowDialog(); // Shows the Customer Form
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmReports log = new frmReports();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmVehicles veh = new frmVehicles(); // Creates an Object 
                veh.ShowDialog(); // Shows the Vehicles Form
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmReports log = new frmReports();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmEmployee emp = new frmEmployee(); // Creates an Object 
                emp.ShowDialog(); // Shows the Employee Form
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmReports log = new frmReports();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin log = new frmLogin();
                log.ShowDialog(); // Goes back to Login Form
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
    }
}