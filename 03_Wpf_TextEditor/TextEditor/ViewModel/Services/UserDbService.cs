using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TextEditor.Model;
using SQLite;
using System.Diagnostics;

namespace TextEditor.ViewModel.Services
{
    public class UserDbService
    {
        static string dbUser = "Userdatabase.db";
        public static string dbRegistrateUsers = Path.Combine(Environment.CurrentDirectory, dbUser);

        public User LoginUser(string login , string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbUser))
            {
                connection.CreateTable<User>();
            var user = connection.Table<User>().Where(u => u.Username == login && u.Password == password).FirstOrDefault();
            return user;
            }
        }

        public bool IsUserExist(User user)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbUser))
            {
                connection.CreateTable<User>();
                var chUser = connection.Table<User>().Where(u => u.Username== user.Username).FirstOrDefault();

                if (chUser == null)
                    return false;
                else
                    return true;
            }
        }

        public  void RegisrateUser(User user)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbRegistrateUsers))
            {
                connection.CreateTable<User>();
                connection.Insert(user);
            }
        }
    }
}
