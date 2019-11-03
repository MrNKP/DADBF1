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
            trackPictureBox.Image = Image.FromFile("D:/Visual Studio Projects/DADBF1/DADBF1/Photos/" + raceLocationLbl.Text + ".png");
            trackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            winnerPictureBox.Image = Image.FromFile("D:/Visual Studio Projects/DADBF1/DADBF1/Photos/" + t.result1.driver1.family_name + ".jpg");
            winnerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            secondPictureBox.Image = Image.FromFile("D:/Visual Studio Projects/DADBF1/DADBF1/Photos/" + t.result1.driver3.family_name + ".jpg");
            secondPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            thirdPictureBox.Image = Image.FromFile("D:/Visual Studio Projects/DADBF1/DADBF1/Photos/" + t.result1.driver4.family_name + ".jpg");
            thirdPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Text = "Race --- " + raceLocationLbl.Text;
        }
    }
}
