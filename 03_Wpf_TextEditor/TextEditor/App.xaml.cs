using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string fNameLoginLog = "LoginLog.txt";
        static string fNameWrongRegistrationLog = "WrongRegistrationLog.txt";
        static string folder = Environment.CurrentDirectory;
        public static string LoginLogPath = Path.Combine(folder, fNameLoginLog);
        public static string WronRegistrationLogPath = Path.Combine(folder, fNameWrongRegistrationLog);
    }
}
