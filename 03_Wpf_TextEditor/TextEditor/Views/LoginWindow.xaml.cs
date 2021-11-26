using SQLite;
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

using TextEditor.Model;
using TextEditor.ViewModel.Services;
using Serilog;
using Serilog.Core;

namespace TextEditor.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private readonly UserDbService _userDbService;
        private readonly MyLogger _myLogger;
        public LoginWindow()
            : this(new UserDbService(), new MyLogger(App.LoginLogPath))
        {

        }
        public LoginWindow(UserDbService userDbService, MyLogger logger)
        {
            InitializeComponent();
            _userDbService = userDbService;


            _myLogger = logger;

        }



        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            var login = loginNameTextBox.Text;
            var password = passwordTextBox.Text;


            var user = _userDbService.LoginUser(login, password);

            if (user != null)
            {
                NotesWindow nw = new NotesWindow();
                nw.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Login or password incorrect!");
                _myLogger.Logger.Error("Incorrect Login : {Login}\tPassword : {Password}", login, password);
            }
        }



        private void registrateBtn_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow(_userDbService);
            this.Visibility = Visibility.Collapsed;
            registerWindow.ShowDialog();
            this.Visibility = Visibility.Visible;

        }
    }
}
