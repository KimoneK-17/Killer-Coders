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
    public partial class frmLocation : Form
    {
        string manager;
        string[] numbers = new string[10];
        public frmLocation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtLocationID.Clear();
                txtManager.Clear();
                updEmployees.Value = 0;
                updVehicles.Value = 0;
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

        public void CheckForNumbers(string manager)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = (x + 1).ToString();
                if (manager.Contains(numbers[x]))
                {
                    MessageBox.Show("The 'Manager In Charge' field cannot contain numbers");
                }
            }
        }

        public void CheckEmpty()
        {
            if(txtLocationID.Text == string.Empty)
            {
                MessageBox.Show("The 'Location ID' field is empty");
            }
            if(txtManager.Text == string.Empty)
            {
                MessageBox.Show("The 'Manager In Charge' field is empty");
            }
            if(cboCity.Text == string.Empty)
            {
                MessageBox.Show("Please select a city from the drop down list");
            }
            if(cboLocationName.Text == string.Empty)
            {
                MessageBox.Show("Please select a location from the drop down list");
            }
            if(cboProvince.Text == string.Empty)
            {
                MessageBox.Show("Please select a province from the drop down list");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            manager = txtManager.Text;
            CheckEmpty();
            CheckForNumbers(manager);
        }
    }
}
