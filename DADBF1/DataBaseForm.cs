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
        public int seasonYear;
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
            List<int> seasons = new List<int>();
            foreach (var item in context.tournaments)
                if (!seasons.Contains(item.season)) seasons.Add(item.season);
            seasonComboBox.DataSource = seasons;
            seasonYear = Convert.ToInt32(seasonComboBox.SelectedItem);
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
                // Info
                driver locd = context.drivers.Find(id);
                using (DriverInfoForm frm = new DriverInfoForm(locd))
                {
                    frm.ShowDialog();
                }
            }
            if (e.ColumnIndex == 24)
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
            if (e.ColumnIndex == 25)
            {
                //Delete
                if (dbm.DeleteDriver(id))
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                driversDataGridView.DataSource = context.drivers.ToList();
            }
        }

        private void teamsShowBtn_Click(object sender, EventArgs e)
        {
            teamsDataGridView.DataSource = dbm.GetTeamView();
        }

        private void tournamentShowBtn_Click(object sender, EventArgs e)
        {
            //List<tournament> t = context.tournaments.ToList();
            //MessageBox.Show(t[0].race1.race_day.Month.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tournamentDataGridView.DataSource = dbm.GetTournamentView(seasonYear);
            /*
            tournamentDataGridView.DataSource = context.results.ToList();
            foreach (var item in context.results.ToList())
            {
                MessageBox.Show(
                    item.driver.family_name + "\n" +
                    item.driver1.family_name + "\n" +
                    item.driver2.family_name + "\n" +
                    item.driver3.family_name + "\n" +
                    item.driver4.family_name + "\n" +
                    item.driver5.family_name + "\n" +
                    item.driver6.family_name + "\n" +
                    item.driver7.family_name + "\n" +
                    item.driver8.family_name + "\n" +
                    item.driver9.family_name + "\n" +
                    item.driver10.family_name + "\n",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            */
        }

        private void tournamentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //10.11.12
            int id = Convert.ToInt32(tournamentDataGridView.CurrentRow.Cells[0].Value);
            if (e.ColumnIndex == 10)
            {
                tournament loct = context.tournaments.Find(id);
                using (TournamentRaceInfoForm frm = new TournamentRaceInfoForm(loct))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
