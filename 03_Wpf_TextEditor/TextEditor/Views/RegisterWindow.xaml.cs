using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using SQLite;
using TextEditor.Model;
using TextEditor.ViewModel.Services;

namespace TextEditor.Views
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        TextBox[] arrTextBox;
        UserDbService _userDbService;
        MyLogger _myLogger;
        
        public RegisterWindow(UserDbService userDbService)
        {
            InitializeComponent();
            _userDbService = userDbService;
            _myLogger = new MyLogger(App.WronRegistrationLogPath);
            arrTextBox = new TextBox[] { fnameTextBox, lnameTextBox, nicknameTextBox, passwordTextBox };
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cancel...\nReturn to login window");
            Close();
        }


        private void registrateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckField()) // valide fields to empty string
                return;

            User user = new User();
            user.FName = fnameTextBox.Text;
            user.LName = lnameTextBox.Text;
            user.Username = nicknameTextBox.Text;
            user.Password = passwordTextBox.Text;


            if (_userDbService.IsUserExist(user) == false)
            {
                _userDbService.RegisrateUser(user);
                Close();
                return;
            }

            MessageBox.Show($"Username {user.Username} is already exist");
            _myLogger.Logger.Information($"Login \"{user.Username}\"\tPassword \"{user.Password}\"");

        }

        private bool CheckText(string text)
        {
            return string.IsNullOrEmpty(text);
        }

        private bool CheckField()
        {

            foreach (var item in arrTextBox)
            {
                if (CheckText(item.Text))
                {
                    MessageBox.Show("Error... Empty field(s)");
                    return false;
                }
            }

            return true;
        }
    }
}
