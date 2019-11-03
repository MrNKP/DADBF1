using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADBF1.Views
{
    class ExtTeam
    {
        public int id { get; set; }
        public string name { get; set; }
        public string driver1SurName { get; set; }
        public string driver1Name { get; set; }
        public string driver2SurName { get; set; }
        public string driver2Name { get; set; }
        public int car1Power { get; set; }
        public int car2Power { get; set; }
        public int? points { get; set; }
    }
}
