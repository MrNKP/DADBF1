using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DADBF1.DataBaseManager;

namespace DADBF1
{
    public partial class DataBaseForm : Form
    {
        private F1GrandPrixContext context;
        private DBManage dbm;
        private String loggedUser;
        public DataBaseForm()
        {
            InitializeComponent();
        }
        public DataBaseForm(String usr)
        {
            InitializeComponent();
            context = new F1GrandPrixContext();
            dbm = new DBManage(context);
            loggedUser = usr;
            loggedUsernameLbl.Text = usr;
        }

        private void driversShowBtn_Click(object sender, EventArgs e)
        {
            driversDataGridView.DataSource = context.drivers.ToList();
        }

        private void driversAddBtn_Click(object sender, EventArgs e)
        {
            using (DriverAddForm frm = new DriverAddForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Add driver
                    if (dbm.CreateDriver(frm.familyNameTextBox.Text, frm.nameTextBox.Text, Convert.ToInt32(frm.experienceTextBox.Text), Convert.ToInt32(frm.trophiesTextBox.Text), Convert.ToInt32(frm.pointsTextBox.Text)) == null)
                        MessageBox.Show("Error Adding");
                    // Update table
                    driversDataGridView.DataSource = context.drivers.ToList();
                }
            }
        }
    }
}
