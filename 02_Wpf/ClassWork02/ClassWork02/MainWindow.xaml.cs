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
using System.Windows.Navigation;
using System.Windows.Shapes;


using ClassWork02.Data.Models;

namespace ClassWork02
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.ShowDialog();

            GetContacts();

        }

        private void GetContacts()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Contact>();
                contacts = connection.Table<Contact>().ToList();
                if (contacts != null)
                {
                    contacts.Sort((i1, i2) => i1.Name.CompareTo(i2.Name));
                    contactsListView.ItemsSource = contacts;
                }
            }
        }
        private void newContactBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateNewWindow createNewWindow = new CreateNewWindow();
            createNewWindow.ShowDialog();
            GetContacts();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(serchTextBox.Text))
            {
                contactsListView.ItemsSource = contacts;
                return;
            }

            List<Contact> res = contacts.Where<Contact>(el => el.Name.Contains(serchTextBox.Text)).ToList();
            if (res != null)
                contactsListView.ItemsSource = res;
        }

        private void contactsListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (contactsListView.SelectedIndex < 0)
                return;

            RedactionItemWindow redactionItemWindow = new RedactionItemWindow(contactsListView.SelectedItem as Contact);
            redactionItemWindow.ShowDialog();

            GetContacts();

        }
    }
}
