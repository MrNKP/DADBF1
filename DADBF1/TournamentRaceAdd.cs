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
    public partial class TournamentRaceAdd : Form
    {
        F1GrandPrixContext db = new F1GrandPrixContext();
        public TournamentRaceAdd()
        {
            InitializeComponent();
            List<string> tracks = new List<string>();
            List<string> pilots = new List<string>();
            foreach(var item in db.races.ToList())
                tracks.Add(item.location);
            trackComboBox.DataSource = tracks;
            foreach (var item in db.drivers.ToList())
                pilots.Add(item.name + " " + item.family_name);
            place1ComboBox.BindingContext = new BindingContext();
            place2ComboBox.BindingContext = new BindingContext();
            place3ComboBox.BindingContext = new BindingContext();
            place4ComboBox.BindingContext = new BindingContext();
            place5ComboBox.BindingContext = new BindingContext();
            place6ComboBox.BindingContext = new BindingContext();
            place7ComboBox.BindingContext = new BindingContext();
            place8ComboBox.BindingContext = new BindingContext();
            place9ComboBox.BindingContext = new BindingContext();
            place10ComboBox.BindingContext = new BindingContext();
            fastLapComboBox.BindingContext = new BindingContext();
            place1ComboBox.DataSource = pilots;
            place2ComboBox.DataSource = pilots;
            place3ComboBox.DataSource = pilots;
            place4ComboBox.DataSource = pilots;
            place5ComboBox.DataSource = pilots;
            place6ComboBox.DataSource = pilots;
            place7ComboBox.DataSource = pilots;
            place8ComboBox.DataSource = pilots;
            place9ComboBox.DataSource = pilots;
            place10ComboBox.DataSource = pilots;
            fastLapComboBox.DataSource = pilots;
        }

        private void trackComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trackname = trackComboBox.SelectedItem.ToString();
            try
            {
                trackInfoPictureBox.Image = Image.FromFile("../../Photos/" + trackname + ".png");
                trackInfoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
            }
        }
    }
}
