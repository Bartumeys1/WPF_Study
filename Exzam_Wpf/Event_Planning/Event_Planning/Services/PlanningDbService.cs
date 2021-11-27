using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Event_Planning.Models;
using SQLite;


namespace Event_Planning.Services
{
    public class PlanningDbService
    {
        static string dbPlann = "PlanningDatabase.db";
        public static string dbPlanningPath = Path.Combine(Environment.CurrentDirectory, dbPlann);

        public List<MyPlann> GetData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbPlanningPath))
            {
                connection.CreateTable<MyPlann>();
                var plan = connection.Table<MyPlann>().ToList();
                return plan;
            }
        }

        public bool IsUserExist(MyPlann plann)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbPlann))
            {
                connection.CreateTable<MyPlann>();
                   var chPlann = connection.Table<MyPlann>().Where(p => p.Name == plann.Name).FirstOrDefault();

                if (chPlann == null)
                    return false;
                else
                    return true;
            }
        }

        public  void RegisrateUser(MyPlann plann)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbPlanningPath))
            {
                connection.CreateTable<MyPlann>();
                connection.Insert(plann);
            }
        }
    }
}
