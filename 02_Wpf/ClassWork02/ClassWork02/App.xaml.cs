using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ClassWork02
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string dbName = "Database.db";
        static string folder = Directory.GetCurrentDirectory();
        public static string dbPath = Path.Combine(folder, dbName);
    }
}
