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
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtServiceID.Clear();
                rtfAppointDescription.Clear(); // Clears text Box
                txtEmployeeName.Clear();
                txtVehicleRegNumber.Clear();
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
        
    private void btnDelete_Click(object sender, EventArgs e)
        {
            try
                {


                    DBConnect objDBConnect = new DBConnect();

                    objDBConnect.OpenConnection();

                    string sql = "DELETE FROM Service WHERE (Service_ID ='"+ S_ID +"');";

                    objDBConnect.sqlCmd = new SqlCommand();
                    objDBConnect.sqlCmd.CommandText = sql;
                    objDBConnect.sqlCmd.Connection = objDBConnect.sqlConn;

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                    
                    MessageBox.Show("SUCCESS");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex.Message);
                }
            }
    }
}
