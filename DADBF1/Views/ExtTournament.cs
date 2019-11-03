using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADBF1.Views
{
    class ExtTournament
    {
        public int id { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public string location { get; set; }
        public int laps { get; set; }
        public string winner { get; set; }
        public string second { get; set; }
        public string third { get; set; }
        public string fastLap { get; set; }
        public int season { get; set; }
    }
}
