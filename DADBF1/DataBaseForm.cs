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
            if (loggedUser == "Admin")
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
            else
                MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (loggedUser == "Admin")
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
                else
                    MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.ColumnIndex == 25)
            {
                if (loggedUser == "Admin")
                {
                    //Delete
                    if (dbm.DeleteDriver(id))
                        MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    driversDataGridView.DataSource = context.drivers.ToList();
                }
                else
                    MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teamsShowBtn_Click(object sender, EventArgs e)
        {
            dbm.SetTeamsPoints();
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
                //Info
                tournament loct = context.tournaments.Find(id);
                using (TournamentRaceInfoForm frm = new TournamentRaceInfoForm(loct))
                {
                    frm.ShowDialog();
                }
            }
            if (e.ColumnIndex == 11)
            {
                if (loggedUser == "Admin")
                {
                    //Delete
                    if (dbm.DeleteRaceFromTournament(id))
                        MessageBox.Show("Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tournamentDataGridView.DataSource = dbm.GetTournamentView(seasonYear);
                }
                else
                    MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tournamentAddBtn_Click(object sender, EventArgs e)
        {
            if (loggedUser == "Admin")
            {
                using (TournamentRaceAdd frm = new TournamentRaceAdd())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        List<string> pilots = new List<string>();
                        pilots.Add(frm.place1ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place2ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place3ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place4ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place5ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place6ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place7ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place8ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place9ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.place10ComboBox.SelectedItem.ToString());
                        pilots.Add(frm.fastLapComboBox.SelectedItem.ToString());
                        dbm.CreateRaceInTournament(seasonYear, frm.trackComboBox.SelectedItem.ToString(), pilots);
                        tournamentDataGridView.DataSource = dbm.GetTournamentView(seasonYear);
                    }
                }
            }
            else
                MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void carsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //7.8
            int id = Convert.ToInt32(carsDataGridView.CurrentRow.Cells[0].Value);
            if (e.ColumnIndex == 7)
            {
                //Edit
                if (loggedUser == "Admin")
                {
                    car c = context.cars.Find(id);
                    using (CarEdit frm = new CarEdit(c))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            if (dbm.EditCar(id, Convert.ToInt32(frm.enginePowerNumericUpDown.Value), Convert.ToDouble(frm.fuelEffNumericUpDown.Value), Convert.ToInt32(frm.resourseNumericUpDown.Value), Convert.ToDouble(frm.weightNumericUpDown.Value)))
                                MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            carsDataGridView.DataSource = context.cars.ToList();
                        }
                    }
                }
                else
                    MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.ColumnIndex == 8)
            {
                if (loggedUser == "Admin")
                {
                    //Delete
                    if (dbm.DeleteDriver(id))
                        MessageBox.Show("Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carsDataGridView.DataSource = context.cars.ToList();
                }
                else
                    MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carsAddBtn_Click(object sender, EventArgs e)
        {
            if (loggedUser == "Admin")
            {
                using (CarEdit frm = new CarEdit())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (dbm.CreateCar(Convert.ToInt32(frm.enginePowerNumericUpDown.Value), Convert.ToDouble(frm.fuelEffNumericUpDown.Value), Convert.ToInt32(frm.resourseNumericUpDown.Value), Convert.ToDouble(frm.weightNumericUpDown.Value)) != null)
                            MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        carsDataGridView.DataSource = context.cars.ToList();
                    }
                }
            }
            else
                MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void teamsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //9.10.11
            int id = Convert.ToInt32(teamsDataGridView.CurrentRow.Cells[0].Value);
            if (e.ColumnIndex == 9)
            {
                //Info
                team loct = context.teams.Find(id);
                using (TeamInfo frm = new TeamInfo(loct))
                {
                    frm.ShowDialog();
                }
            }
            if (e.ColumnIndex == 10)
            {
                if (loggedUser == "Admin")
                {
                    //Edit
                    team loct = context.teams.Find(id);
                    using (TeamEdit frm = new TeamEdit(loct))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            dbm.EditTeam(id, frm.teamTextBox.Text, frm.driver1ComboBox.SelectedItem.ToString(), frm.driver2ComboBox.SelectedItem.ToString(), frm.car1ComboBox.SelectedItem.ToString(), frm.car2ComboBox.SelectedItem.ToString());
                            teamsDataGridView.DataSource = dbm.GetTeamView();
                        }
                    }
                }
                else
                    MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.ColumnIndex == 11)
            {
                if (loggedUser == "Admin")
                {
                    //Delete
                    dbm.DeleteTeam(id);
                    teamsDataGridView.DataSource = dbm.GetTeamView();
                }
                else
                    MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teamsAddBtn_Click(object sender, EventArgs e)
        {
            if (loggedUser == "Admin")
            {
                using (TeamEdit frm = new TeamEdit())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        dbm.CreateTeam(frm.teamTextBox.Text, frm.driver1ComboBox.SelectedItem.ToString(), frm.driver2ComboBox.SelectedItem.ToString(), frm.car1ComboBox.SelectedItem.ToString(), frm.car2ComboBox.SelectedItem.ToString());
                        //dbm.SetTeamsPoints();
                        teamsDataGridView.DataSource = dbm.GetTeamView();
                    }
                }
            }
            else
                MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
