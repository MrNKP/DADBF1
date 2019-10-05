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
    public partial class DriverEditForm : Form
    {
        driver d;
        public DriverEditForm()
        {
            InitializeComponent();
        }
        public DriverEditForm(driver nd)
        {
            InitializeComponent();
            d = nd;
            familyNameTextBox.Text = d.family_name;
            nameTextBox.Text = d.name;
            countryTextBox.Text = d.country;
            birthTextBox.Text = Convert.ToString(d.birth);
            podiumsTextBox.Text = Convert.ToString(d.podiums);
            experienceTextBox.Text = Convert.ToString(d.experience);
            trophiesTextBox.Text = Convert.ToString(d.trophies);
            numberTextBox.Text = Convert.ToString(d.number);
            pointsTextBox.Text = Convert.ToString(d.points);
        }
    }
}
