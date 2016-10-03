using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FleetTrackingInformationSystem
{
    public partial class frmReports : Form
    {
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataGridView DataSource;
        public frmReports()
        {
            InitializeComponent();
        }
        private void frmReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FleetTrackingDBDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.VehicleTableAdapter.Fill(this.FleetTrackingDBDataSet.Vehicle);

            //sql data grids

            string select = "SELECT * FROM SqlFleetCreate";
            SqlConnection Report = new SqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, Report); //Report is the connection string
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvVehicleStatus.ReadOnly = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
                men.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go Back to the Previous Form: " + ex.Message); // Shows an error message 
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch(Exception ex)
            {        
                MessageBox.Show("Cannot Exit the Application: " + ex.Message); // Shows an error message 
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
