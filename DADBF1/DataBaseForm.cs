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
            using (DriverEditForm frm = new DriverEditForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Add driver
                    if (dbm.CreateDriver(frm.familyNameTextBox.Text, frm.nameTextBox.Text, frm.countryTextBox.Text, Convert.ToDateTime(frm.birthTextBox.Text), Convert.ToInt32(frm.podiumsTextBox.Text), Convert.ToInt32(frm.experienceTextBox.Text), Convert.ToInt32(frm.trophiesTextBox.Text), Convert.ToInt32(frm.numberTextBox.Text), Convert.ToInt32(frm.pointsTextBox.Text)) == null)
                        MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Update table
                    driversDataGridView.DataSource = context.drivers.ToList();
                }
            }
        }

        private void carsShowBtn_Click(object sender, EventArgs e)
        {
            carsDataGridView.DataSource = context.cars.ToList();
        }

        private void driversDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //23.24
            int id = Convert.ToInt32(driversDataGridView.CurrentRow.Cells[0].Value);
            if (e.ColumnIndex == 23)
            {
                //Edit
                driver locd = context.drivers.Find(id);
                using (DriverEditForm frm = new DriverEditForm(locd))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (dbm.EditDriver(id, frm.familyNameTextBox.Text, frm.nameTextBox.Text, frm.countryTextBox.Text, Convert.ToDateTime(frm.birthTextBox.Text), Convert.ToInt32(frm.podiumsTextBox.Text), Convert.ToInt32(frm.experienceTextBox.Text), Convert.ToInt32(frm.trophiesTextBox.Text), Convert.ToInt32(frm.numberTextBox.Text), Convert.ToInt32(frm.pointsTextBox.Text)))
                            MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        driversDataGridView.DataSource = context.drivers.ToList();
                    }
                }
            }
            if (e.ColumnIndex == 24)
            {
                //Delete
                if (dbm.DeleteDriver(id))
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                driversDataGridView.DataSource = context.drivers.ToList();
            }
        }
    }
}
