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
    }
}
