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
    public partial class DriverInfoForm : Form
    {
        public DriverInfoForm()
        {
            InitializeComponent();
        }
        public DriverInfoForm(driver d)
        {
            InitializeComponent();
            driverFamilyName.Text = d.family_name;
            driverName.Text = d.name;
            driverCountry.Text = d.country;
            driverBirth.Text = d.birth.ToShortDateString();
            driverPodiums.Text = d.podiums.ToString();
            driverExperience.Text = d.experience.ToString();
            driverTrophies.Text = d.trophies.ToString();
            driverNumber.Text = d.number.ToString();
            string path = System.IO.Directory.GetCurrentDirectory();
            try
            {
                driverPhotoPictureBox.Image = Image.FromFile("../../Photos/" + driverFamilyName.Text + ".jpg");
                //driverPhotoPictureBox.ImageLocation = "./Photos/" + driverFamilyName.Text + ".jpg";
                driverPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                //MessageBox.Show("No Photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Text = "Driver --- " + driverName.Text + " " + driverFamilyName.Text;
        }
    }
}
