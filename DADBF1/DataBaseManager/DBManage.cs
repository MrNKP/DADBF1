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
        public driver CreateDriver (string fn, string n, string c, DateTime b, int p, int e, int t, int num, int pts)
        {
            driver d = db.drivers.Where(p1 => (p1.family_name == fn) && (p1.name == n) && (p1.country == c) && (p1.birth == b) && (p1.podiums == p) && (p1.experience == e) && (p1.trophies == t) && (p1.number == num) && (p1.points == pts)).FirstOrDefault();
            if (d != null) return null;
            else
            {
                d = new driver();
                d.family_name = fn;
                d.name = n;
                d.country = c;
                d.birth = b;
                d.podiums = p;
                d.experience = e;
                d.trophies = t;
                d.number = num;
                d.points = pts;
                db.drivers.Add(d);
                db.SaveChanges();
                return d;
            }
        }
        public bool EditDriver(int id, string fn, string n, string c, DateTime b, int p, int e, int t, int num, int pts)
        {
            driver d = db.drivers.Find(id);
            if (d != null)
            {
                d.family_name = fn;
                d.name = n;
                d.country = c;
                d.birth = b;
                d.podiums = p;
                d.experience = e;
                d.trophies = t;
                d.number = num;
                d.points = pts;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public bool DeleteDriver(int id)
        {
            driver d = db.drivers.Find(id);
            if (d != null)
            {
                db.drivers.Remove(d);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
