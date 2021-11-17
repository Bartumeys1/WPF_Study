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
using ClassWork02.Data.Models;

namespace ClassWork02
{
    /// <summary>
    /// Логика взаимодействия для RedactionItemWindow.xaml
    /// </summary>
    public partial class RedactionItemWindow : Window
    {
        private Contact contact;
        public RedactionItemWindow()
        {
            InitializeComponent();
        }
        public RedactionItemWindow(Contact selectedResource)
           : this()
        {
            contact = selectedResource;
            InitFields();
        }


        private void InitFields()
        {
            nameTextBox.Text = contact.Name;
            emailTextBox.Text = contact.Email;
            phoneTextBox.Text = contact.Phone;
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.Delete(contact);

                contact.Name = nameTextBox.Text;
                contact.Email = emailTextBox.Text;
                contact.Phone = phoneTextBox.Text;
                connection.Insert(contact);
            }
            Close();

        }
    }
}
