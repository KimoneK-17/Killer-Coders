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
    public partial class frmVehicles : Form
    {
        string mileage;
        double doubleTryParseOut;
        public frmVehicles()
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
                txtRegNum.Clear();
                txtMileage.Clear();
                txtModel.Clear();
                txtMake.Clear();
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

        public void CheckForLetters(string mileage)
        {
            if (double.TryParse(mileage, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'Vehicle Mileage' field cannot contain letters");
            }
        }

        public void CheckEmpty()
        {
            if(txtMake.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Make' field is empty");
            }
            if(txtMileage.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Mileage' field is empty");
            }
            if(txtModel.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Model' field is empty");
            }
            if(txtRegNum.Text == string.Empty)
            {
                MessageBox.Show("The 'Registration Number' field is empty");
            }
            if(cboType.Text == string.Empty)
            {
                MessageBox.Show("Please select a vehicle type from the drop down list");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            mileage = txtMileage.Text;
            CheckEmpty();
            CheckForLetters(mileage);
        }
    }
}
