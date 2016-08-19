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
    public partial class frmTripUsage : Form
    {
        double doubleTryParseOut;
        string kmTravelled;
        string fuelUsage;
        public frmTripUsage()
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
                txtTripID.Clear();
                txtFuelUsage.Clear();
                txtVehicleIncidents.Clear(); // Clears Text Box
                txtVehicleRegNumber.Clear();
                txtKM.Clear();
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

        public void CheckForLetters(string fuelUsage, string kmTravelled)
        {
            if (double.TryParse(fuelUsage, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'Fuel Usage' field cannot contain letters");
            }
            if (double.TryParse(kmTravelled, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'KM Travelled' field cannot contain letters");
            }
        }

        public void CheckEmpty()
        {
            if(txtFuelUsage.Text == string.Empty)
            {
                MessageBox.Show("The 'Fuel Usage' field is empty");
            }
            if(txtKM.Text == string.Empty)
            {
                MessageBox.Show("The 'KM Travelled' field is empty");
            }
            if(txtTripID.Text == string.Empty)
            {
                MessageBox.Show("The 'Trip ID' field is empty");
            }
            if(txtVehicleIncidents.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Incidents' field is empty");
            }
            if(txtVehicleRegNumber.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Reg Number' field is empty");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fuelUsage = txtFuelUsage.Text;
            kmTravelled = txtKM.Text;
            CheckEmpty();
            CheckForLetters(fuelUsage, kmTravelled);
        }
    }
}
