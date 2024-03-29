﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DADBF1
{
    public partial class StartFormLogin : Form
    {
        public StartFormLogin()
        {
            InitializeComponent();
        }

        private void guestBtn_Click(object sender, EventArgs e)
        {
            DataBaseForm dbsf = new DataBaseForm("Guest");
            this.Hide();
            dbsf.ShowDialog();
            this.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Admin" && passwordTextBox.Text == "1234")
            {
                DataBaseForm dbsf = new DataBaseForm("Admin");
                this.Hide();
                dbsf.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Invalid Username/PassWord", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
