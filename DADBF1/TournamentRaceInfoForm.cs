using System;
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
    public partial class TournamentRaceInfoForm : Form
    {
        public TournamentRaceInfoForm()
        {
            InitializeComponent();
        }
        public TournamentRaceInfoForm(tournament t)
        {
            InitializeComponent();
            raceLocationLbl.Text = t.race1.location;
            raceDateLbl.Text = t.race1.race_day.ToShortDateString();
            raceLapsLbl.Text = t.race1.laps.ToString();
            raceWinnerLbl.Text = t.result1.driver1.name + ' ' + t.result1.driver1.family_name;
            raceSecondLbl.Text = t.result1.driver3.name + ' ' + t.result1.driver3.family_name;
            raceThirdLbl.Text = t.result1.driver4.name + ' ' + t.result1.driver4.family_name;
            try
            {
                trackPictureBox.Image = Image.FromFile("../../Photos/" + raceLocationLbl.Text + ".png");
                trackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                //MessageBox.Show("No Track Sceme", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                winnerPictureBox.Image = Image.FromFile("../../Photos/" + t.result1.driver1.family_name + ".jpg");
                winnerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                //MessageBox.Show("No Winner Photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                secondPictureBox.Image = Image.FromFile("../../Photos/" + t.result1.driver3.family_name + ".jpg");
                secondPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                //MessageBox.Show("No Second Place Photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                thirdPictureBox.Image = Image.FromFile("../../Photos/" + t.result1.driver4.family_name + ".jpg");
                thirdPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                //MessageBox.Show("No Third Place Photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Text = "Race --- " + raceLocationLbl.Text;
        }
    }
}
