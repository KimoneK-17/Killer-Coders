﻿using System;
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
    public partial class frmSplashScreen : Form
    {
        private Timer closeTimer = new Timer();

        public frmSplashScreen()
        {
            InitializeComponent();

            closeTimer.Interval = 3000; //3 seconds
            closeTimer.Tick += new EventHandler(closeTimer_Tick);
            closeTimer.Start();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
