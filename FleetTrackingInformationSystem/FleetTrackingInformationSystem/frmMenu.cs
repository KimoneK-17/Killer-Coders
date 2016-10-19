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
                ser.Show(); // Shows the Service Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Service Form: " + ex.Message); // Shows an error message 
            }
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmTripPlan tU = new frmTripPlan(); // Creates an Object 
                tU.Show(); // Shows the Trip and Usage Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Trip Form: " + ex.Message); // Shows an error message 
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmReports rp = new frmReports(); // Creates an Object 
                rp.Show(); // Shows the Report Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Reports Form: " + ex.Message); // Shows an error message 
            }
        }

        private void btnScheduling_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmTimesheet tS = new frmTimesheet(); // Creates an Object 
                tS.Show(); // Shows the Timesheet Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Scheduling Form: " + ex.Message); // Shows an error message 
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmLocation loc = new frmLocation(); // Creates an Object 
                loc.Show(); // Shows the Location Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Location Form: " + ex.Message); // Shows an error message 
            }
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmCustomer cus = new frmCustomer(); // Creates an Object 
                cus.Show(); // Shows the Customer Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Customer Form: " + ex.Message); // Shows an error message
            }
        }
        private void btnVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmVehicles veh = new frmVehicles(); // Creates an Object 
                veh.Show(); // Shows the Vehicle Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Vehicle Form: " + ex.Message); // Shows an error message 
            }
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Will Hide this Form
                frmEmployee emp = new frmEmployee(); // Creates an Object 
                emp.Show(); // Shows the Employee Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Employee Form: " + ex.Message); // Shows an error message
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Exit The Application: " + ex.Message); // Shows an error message 
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin log = new frmLogin();
                log.Show(); // Goes back to Login Form
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Logout of System: " + ex.Message); // Shows an error message
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmSearch search = new frmSearch();
                search.Show(); // Goes To the Search Form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Search Form: " + ex.Message); // Shows an error message 
            }
        }   
    }
}
