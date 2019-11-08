using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DADBF1.Views;

namespace DADBF1.DataBaseManager
{
    class DBManage
    {
        private string[] monthes = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "Octoer", "November", "December" };
        private F1GrandPrixContext db;
        public DBManage(F1GrandPrixContext context)
        {
            db = context;
        }
        // ===== Views =====
        public List<ExtTeam> GetTeamView()
        {
            var k = db.teams.Select(e => new ExtTeam
            {
                id = e.id,
                name = e.name,
                driver1SurName = e.driver.family_name,
                driver1Name = e.driver.name,
                driver2SurName = e.driver3.family_name,
                driver2Name = e.driver3.name,
                car1Power = e.car.power_eng,
                car2Power = e.car3.power_eng,
                points = e.points
            });
            return k.ToList();
        }
        public List<ExtTournament> GetTournamentView(int locSeason)
        {
            //var loc = db.tournaments.Where(p => p.season.Equals(locSeason));
            var k = db.tournaments.Where(p => p.season.Equals(locSeason)).Select(e => new ExtTournament
            //var k = db.tournaments.Select(e => new ExtTournament
            {
                id = e.id,
                day = e.race1.race_day.Day,
                //month = monthes[e.race1.race_day.Month-1],
                month = e.race1.race_day.Month,
                location = e.race1.location,
                laps = e.race1.laps,
                winner = e.result1.driver1.family_name,
                second = e.result1.driver3.family_name,
                third = e.result1.driver4.family_name,
                fastLap = e.result1.driver.family_name,
                season = locSeason
            });
            return k.ToList();
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
        // ===== Races =====
        public bool SetTeamsPoints()
        {
            List<team> t = db.teams.ToList();
            for (int i=0; i<t.Count; i++)
            {
                t[i].points = t[i].driver.points + t[i].driver3.points;
                db.SaveChanges();
            }
            return true;
        }
        private bool SetPoints(List<driver> drv, int mode)
        {
            for (int i=0; i<11; i++)
            {
                switch (i)
                {
                    case 0:
                        if (mode == 1)
                        {
                            drv[i].points += 25;
                            drv[i].podiums++;
                        }
                        else
                        {
                            drv[i].points -= 25;
                            drv[i].podiums--;
                        }
                        break;
                    case 1:
                        if (mode == 1)
                        {
                            drv[i].points += 18;
                            drv[i].podiums++;
                        }
                        else
                        {
                            drv[i].points -= 18;
                            drv[i].podiums--;
                        }
                        break;
                    case 2:
                        if (mode == 1)
                        {
                            drv[i].points += 15;
                            drv[i].podiums++;
                        }
                        else
                        {
                            drv[i].points -= 15;
                            drv[i].podiums--;
                        }
                        break;
                    case 3:
                        if (mode == 1)
                            drv[i].points += 12;
                        else
                            drv[i].points -= 12;
                        break;
                    case 4:
                        if (mode == 1)
                            drv[i].points += 10;
                        else
                            drv[i].points -= 10;
                        break;
                    case 5:
                        if (mode == 1)
                            drv[i].points += 8;
                        else
                            drv[i].points -= 8;
                        break;
                    case 6:
                        if (mode == 1)
                            drv[i].points += 6;
                        else
                            drv[i].points -= 6;
                        break;
                    case 7:
                        if (mode == 1)
                            drv[i].points += 4;
                        else
                            drv[i].points -= 4;
                        break;
                    case 8:
                        if (mode == 1)
                            drv[i].points += 2;
                        else
                            drv[i].points -= 2;
                        break;
                    case 9:
                        if (mode == 1)
                            drv[i].points += 1;
                        else
                            drv[i].points -= 1;
                        break;
                    case 10:
                        if (mode == 1)
                            drv[i].points += 1;
                        else
                            drv[i].points -= 1;
                        break;
                    default:
                        if (mode == 1)
                            drv[i].points += 0;
                        else
                            drv[i].points -= 0;
                        break;
                }
                db.SaveChanges();
            }
            return true;
        }
        private result CreateResult(List<string> pos)
        {
            result r = new result();
            List<driver> d = new List<driver>(11);
            foreach (string item in pos)
            {
                char space = ' ';
                int position = item.IndexOf(space);
                string dname = item.Substring(0, position);
                string dfamily_name = item.Substring(position + 1);
                driver locd = db.drivers.Where(e => (e.name.Equals(dname)) && (e.family_name.Equals(dfamily_name))).FirstOrDefault();
                d.Add(locd);
            }
            r.place1 = d[0].id;
            r.place2 = d[1].id;
            r.place3 = d[2].id;
            r.place4 = d[3].id;
            r.place5 = d[4].id;
            r.place6 = d[5].id;
            r.place7 = d[6].id;
            r.place8 = d[7].id;
            r.place9 = d[8].id;
            r.place10 = d[9].id;
            r.fastlap = d[10].id;
            db.results.Add(r);
            db.SaveChanges();
            if (SetPoints(d, 1) && SetTeamsPoints())
            {
                for (int i=0; i<db.drivers.ToList().Count; i++)
                {
                    db.drivers.ToList()[i].experience++;
                    db.SaveChanges();
                }
                return r;
            }
            return null;
        }
        public tournament CreateRaceInTournament(int s, string tr, List<string> pos)//string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string fl)
        {
            //int lastid = db.races.ToList().Last().id;
            result r = CreateResult(pos);
            race rc = db.races.Where(e => e.location.Equals(tr)).FirstOrDefault();
            tournament t = new tournament();
            t.race = rc.id;
            t.result = r.id;
            t.season = s;
            db.tournaments.Add(t);
            db.SaveChanges();
            return t;
        }
        private bool DeleteResult(int id)
        {
            result r = db.results.Find(id);
            if (r != null)
            {
                List<driver> drv = new List<driver>();
                drv.Add(db.drivers.Find(r.place1));
                drv.Add(db.drivers.Find(r.place2));
                drv.Add(db.drivers.Find(r.place3));
                drv.Add(db.drivers.Find(r.place4));
                drv.Add(db.drivers.Find(r.place5));
                drv.Add(db.drivers.Find(r.place6));
                drv.Add(db.drivers.Find(r.place7));
                drv.Add(db.drivers.Find(r.place8));
                drv.Add(db.drivers.Find(r.place9));
                drv.Add(db.drivers.Find(r.place10));
                drv.Add(db.drivers.Find(r.fastlap));
                db.results.Remove(r);
                db.SaveChanges();
                if (SetPoints(drv, 0) && SetTeamsPoints())
                    return true;
                return false;
            }
            return false;
        }
        public bool DeleteRaceFromTournament(int id)
        {
            tournament t = db.tournaments.Find(id);
            if (t != null)
            {
                int resId = t.result;
                db.tournaments.Remove(t);
                db.SaveChanges();
                if (DeleteResult(resId))
                    return true;
                return false;
            }
            return false;
        }
        // ===== Cars =====
        public car CreateCar(int p, double f, int r, double w)
        {
            car c = db.cars.Where(e => (e.power_eng == p) && (e.fuel_eff == f) && (e.resourse == r) && (e.car_weight == w)).FirstOrDefault();
            if (c != null) return null;
            else
            {
                c = new car();
                c.power_eng = p;
                c.fuel_eff = f;
                c.resourse = r;
                c.car_weight = w;
                db.cars.Add(c);
                db.SaveChanges();
                return c;
            }
        }
        public bool DeleteCar(int id)
        {
            car c = db.cars.Find(id);
            if (c != null)
            {
                db.cars.Remove(c);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EditCar(int id, int p, double f, int r, double w)
        {
            car c = db.cars.Find(id);
            if (c != null)
            {
                c.power_eng = p;
                c.fuel_eff = f;
                c.resourse = r;
                c.car_weight = w;
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
        // ===== Teams =====
        public team CreateTeam(string n, string d1, string d2, string c1, string c2)
        {
            char space = ' ';
            int pos = d1.IndexOf(space);
            string driver1Name = d1.Substring(0, pos);
            string driver1SurName = d1.Substring(pos + 1);
            //
            pos = d2.IndexOf(space);
            string driver2Name = d1.Substring(0, pos);
            string driver2SurName = d1.Substring(pos + 1);
            //
            pos = c1.IndexOf(space);
            string c1Power = c1.Substring(0, pos + 1);
            string tmp = c1.Substring(pos + 1);
            c1 = tmp;
            pos = c1.IndexOf(space);
            string c1Res = c1.Substring(0, pos);
            tmp = c1.Substring(pos + 1);
            c1 = tmp;
            pos = c1.IndexOf(space);
            string c1Fuel = c1.Substring(0, pos);
            string c1Weight = c1.Substring(pos + 1);
            int car1Power = Convert.ToInt32(c1Power);
            int car1Resourse = Convert.ToInt32(c1Res);
            double car1Fuel = Convert.ToDouble(c1Fuel);
            double car1Weight = Convert.ToDouble(c1Weight);
            //
            pos = c2.IndexOf(space);
            string c2Power = c2.Substring(0, pos + 1);
            tmp = c2.Substring(pos + 1);
            c2 = tmp;
            pos = c2.IndexOf(space);
            string c2Res = c2.Substring(0, pos);
            tmp = c2.Substring(pos + 1);
            c2 = tmp;
            pos = c2.IndexOf(space);
            string c2Fuel = c2.Substring(0, pos);
            string c2Weight = c2.Substring(pos + 1);
            int car2Power = Convert.ToInt32(c2Power);
            int car2Resourse = Convert.ToInt32(c2Res);
            double car2Fuel = Convert.ToDouble(c2Fuel);
            double car2Weight = Convert.ToDouble(c2Weight);
            //
            try
            {
                team t = new team();
                driver dr1 = db.drivers.Where(e => e.name.Equals(driver1Name) && (e.family_name.Equals(driver1SurName))).FirstOrDefault();
                driver dr2 = db.drivers.Where(e => e.name.Equals(driver2Name) && (e.family_name.Equals(driver2SurName))).FirstOrDefault();
                car cr1 = db.cars.Where(e => (e.power_eng == car1Power) && (e.resourse == car1Resourse) && (e.fuel_eff == car1Fuel) && (e.car_weight == car1Weight)).FirstOrDefault();
                car cr2 = db.cars.Where(e => (e.power_eng == car2Power) && (e.resourse == car2Resourse) && (e.fuel_eff == car2Fuel) && (e.car_weight == car2Weight)).FirstOrDefault();
                //team t = new team();
                t.name = n;
                t.driver1 = dr1.id;
                t.driver2 = dr2.id;
                t.car1 = cr1.id;
                t.car2 = cr2.id;
                db.teams.Add(t);
                db.SaveChanges();
                return t;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool EditTeam(int id, string n, string d1, string d2, string c1, string c2)
        {
            team t = db.teams.Find(id);
            if (t == null)
                return false;
            char space = ' ';
            int pos = d1.IndexOf(space);
            string driver1Name = d1.Substring(0, pos);
            string driver1SurName = d1.Substring(pos + 1);
            //
            pos = d2.IndexOf(space);
            string driver2Name = d1.Substring(0, pos);
            string driver2SurName = d1.Substring(pos + 1);
            //
            pos = c1.IndexOf(space);
            string c1Power = c1.Substring(0, pos + 1);
            string tmp = c1.Substring(pos + 1);
            c1 = tmp;
            pos = c1.IndexOf(space);
            string c1Res = c1.Substring(0, pos);
            tmp = c1.Substring(pos + 1);
            c1 = tmp;
            pos = c1.IndexOf(space);
            string c1Fuel = c1.Substring(0, pos);
            string c1Weight = c1.Substring(pos + 1);
            int car1Power = Convert.ToInt32(c1Power);
            int car1Resourse = Convert.ToInt32(c1Res);
            double car1Fuel = Convert.ToDouble(c1Fuel);
            double car1Weight = Convert.ToDouble(c1Weight);
            //
            pos = c2.IndexOf(space);
            string c2Power = c2.Substring(0, pos + 1);
            tmp = c2.Substring(pos + 1);
            c2 = tmp;
            pos = c2.IndexOf(space);
            string c2Res = c2.Substring(0, pos);
            tmp = c2.Substring(pos + 1);
            c2 = tmp;
            pos = c2.IndexOf(space);
            string c2Fuel = c2.Substring(0, pos);
            string c2Weight = c2.Substring(pos + 1);
            int car2Power = Convert.ToInt32(c2Power);
            int car2Resourse = Convert.ToInt32(c2Res);
            double car2Fuel = Convert.ToDouble(c2Fuel);
            double car2Weight = Convert.ToDouble(c2Weight);
            try
            {
                driver dr1 = db.drivers.Where(e => e.name.Equals(driver1Name) && (e.family_name.Equals(driver1SurName))).FirstOrDefault();
                driver dr2 = db.drivers.Where(e => e.name.Equals(driver2Name) && (e.family_name.Equals(driver2SurName))).FirstOrDefault();
                car cr1 = db.cars.Where(e => (e.power_eng == car1Power) && (e.resourse == car1Resourse) && (e.fuel_eff == car1Fuel) && (e.car_weight == car1Weight)).FirstOrDefault();
                car cr2 = db.cars.Where(e => (e.power_eng == car2Power) && (e.resourse == car2Resourse) && (e.fuel_eff == car2Fuel) && (e.car_weight == car2Weight)).FirstOrDefault();
                t.name = n;
                t.driver1 = dr1.id;
                t.driver2 = dr2.id;
                t.car1 = cr1.id;
                t.car2 = cr2.id;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteTeam(int id)
        {
            team t = db.teams.Find(id);
            try
            {
                db.teams.Remove(t);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
