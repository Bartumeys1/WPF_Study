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

using ClassWork02.Data.Models;
using SQLite;

namespace ClassWork02
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        Authorization client;
        List<Authorization> clientsData;
        public AuthorizationWindow()
        {
            InitializeComponent();
            clientsData = new List<Authorization>();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            getClientsData();
            client = new Authorization();
            client.Name = loginNameTextBox.Text;
            client.Password = passwordTextBox.Text;

            if (getAccess())
            {
                MessageBox.Show($"Hello \"{client.Name}\"");
                Close();
                return;
            }
            MessageBox.Show($"Login false ! Pleas registrate in system...");
        }

        private void getClientsData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.dbPathLogin))
            {
                connection.CreateTable<Authorization>();
                clientsData = connection.Table<Authorization>().ToList();

                if (clientsData == null)
                    clientsData = new List<Authorization>();
            }
        }

        private bool getAccess()
        {
            if (clientsData != null)
                foreach (var item in clientsData)
                {
                    if (item.Name == client.Name && item.Password == client.Password)
                    {
                        return true;
                    }
                }

            return false;
        }
        private void registrateBtn_Click(object sender, RoutedEventArgs e)
        {
            client = new Authorization();
            client.Name = loginNameTextBox.Text;
            client.Password = passwordTextBox.Text;
            using (SQLiteConnection connection = new SQLiteConnection(App.dbPathLogin))
            {
                connection.CreateTable<Authorization>();
                connection.Insert(client);

                loginNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }

        }
    }
}
