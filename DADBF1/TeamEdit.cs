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
    public partial class TeamEdit : Form
    {
        F1GrandPrixContext db = new F1GrandPrixContext();
        public TeamEdit()
        {
            InitializeComponent();
            List<string> pilots = new List<string>();
            List<string> vehicles = new List<string>();
            foreach (var item in db.drivers)
                pilots.Add(item.name + " " + item.family_name);
            foreach (var item in db.cars)
                vehicles.Add(item.power_eng + " " + item.resourse + " " + item.fuel_eff + " " + item.car_weight);
            driver1ComboBox.BindingContext = new BindingContext();
            driver2ComboBox.BindingContext = new BindingContext();
            car1ComboBox.BindingContext = new BindingContext();
            car2ComboBox.BindingContext = new BindingContext();
            driver1ComboBox.DataSource = pilots;
            driver2ComboBox.DataSource = pilots;
            car1ComboBox.DataSource = vehicles;
            car2ComboBox.DataSource = vehicles;
            this.Text = "New Team";
        }

        public TeamEdit(team t)
        {
            InitializeComponent();
            List<string> pilots = new List<string>();
            List<string> vehicles = new List<string>();
            foreach (var item in db.drivers)
                pilots.Add(item.name + " " + item.family_name);
            foreach (var item in db.cars)
                vehicles.Add(item.power_eng + " " + item.resourse + " " + item.fuel_eff + " " + item.car_weight);
            driver1ComboBox.BindingContext = new BindingContext();
            driver2ComboBox.BindingContext = new BindingContext();
            car1ComboBox.BindingContext = new BindingContext();
            car2ComboBox.BindingContext = new BindingContext();
            driver1ComboBox.DataSource = pilots;
            driver2ComboBox.DataSource = pilots;
            car1ComboBox.DataSource = vehicles;
            car2ComboBox.DataSource = vehicles;
            teamTextBox.Text = t.name;
            driver1ComboBox.SelectedItem = t.driver.name + " " + t.driver.family_name;
            driver2ComboBox.SelectedItem = t.driver3.name + " " + t.driver3.family_name;
            car1ComboBox.SelectedItem = t.car.power_eng + " " + t.car.resourse + " " + t.car.fuel_eff + " " + t.car.car_weight;
            car2ComboBox.SelectedItem = t.car3.power_eng + " " + t.car3.resourse + " " + t.car3.fuel_eff + " " + t.car3.car_weight;
            this.Text = "Edit --- " + t.name;
        }
    }
}
