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
    public partial class TeamInfo : Form
    {
        private team loct;
        public TeamInfo()
        {
            InitializeComponent();
            loct = null;
        }
        public TeamInfo(team t)
        {
            InitializeComponent();
            loct = t;
            this.Text = "Info --- " + t.name;
            teamNameOutLbl.Text = t.name;
            teamPointsOutLbl.Text = t.points.ToString();
            driver1NameLbl.Text = t.driver.name + " " + t.driver.family_name;
            driver2NameLbl.Text = t.driver3.name + " " + t.driver3.family_name;
            /*
             *try
            {
                trackPictureBox.Image = Image.FromFile("D:/Visual Studio Projects/DADBF1/DADBF1/Photos/" + raceLocationLbl.Text + ".png");
                trackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                //MessageBox.Show("No Track Sceme", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
             */
            try
            {
                logoPictureBox.Image = Image.FromFile("../../Photos/" + teamNameOutLbl.Text + ".jpg");
                logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

            }
            try
            {
                carPictureBox.Image = Image.FromFile("../../Photos/" + teamNameOutLbl.Text + "Car.png");
                carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

            }
            try
            {
                driver1PictureBox.Image = Image.FromFile("../../Photos/" + t.driver.family_name + ".jpg");
                driver1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

            }
            try
            {
                driver2PictureBox.Image = Image.FromFile("../../Photos/" + t.driver3.family_name + ".jpg");
                driver2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

            }
        }
        private void driver1InfoBtn_Click(object sender, EventArgs e)
        {
            using (DriverInfoForm frm = new DriverInfoForm(loct.driver))
            {
                frm.ShowDialog();
            }
        }

        private void driver2InfoBtn_Click(object sender, EventArgs e)
        {
            using (DriverInfoForm frm = new DriverInfoForm(loct.driver3))
            {
                frm.ShowDialog();
            }
        }

        private void car1Btn_Click(object sender, EventArgs e)
        {
            using (CarEdit frm = new CarEdit(loct.car))
            {
                frm.ShowDialog();
            }
        }

        private void car2Btn_Click(object sender, EventArgs e)
        {
            using (CarEdit frm = new CarEdit(loct.car3))
            {
                frm.ShowDialog();
            }
        }
    }
}
