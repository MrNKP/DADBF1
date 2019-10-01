using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADBF1.DataBaseManager
{
    class DBManage
    {
        private F1GrandPrixContext db;
        public DBManage(F1GrandPrixContext context)
        {
            db = context;
        }
        // ===== Driver =====
        public driver CreateDriver (String dfamilyName, String dname, int dexp, int dtr, int dpts)
        {
            driver driv = db.drivers.Where(p => (p.family_name == dfamilyName) && (p.name == dname) && (p.experience == dexp) && (p.trophies == dtr) && (p.points == dpts)).FirstOrDefault();
            if (driv != null) return null;
            else
            {
                driver drv = new DADBF1.driver();
                drv.family_name = dfamilyName;
                drv.name = dname;
                drv.experience = dexp;
                drv.trophies = dtr;
                drv.points = dpts;
                db.drivers.Add(drv);
                db.SaveChanges();
                return drv;
            }
        }
    }
}
