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
    public partial class CarEdit : Form
    {
        public CarEdit()
        {
            InitializeComponent();
            this.Text = "New Car";
        }
        public CarEdit(car c)
        {
            InitializeComponent();
            enginePowerNumericUpDown.Value = c.power_eng;
            fuelEffNumericUpDown.Value = Convert.ToDecimal(c.fuel_eff);
            resourseNumericUpDown.Value = c.resourse;
            weightNumericUpDown.Value = Convert.ToDecimal(c.car_weight);
            this.Text = "Car #" + c.id;
        }
    }
}
