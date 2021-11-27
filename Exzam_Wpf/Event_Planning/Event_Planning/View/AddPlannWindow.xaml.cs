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

using Event_Planning.Models;
using Event_Planning.Services;

namespace Event_Planning.View
{
    /// <summary>
    /// Логика взаимодействия для AddPlannWindow.xaml
    /// </summary>
    public partial class AddPlannWindow : Window
    {
        private string _selestPriority;
        private PlanningDbService _planningDbService;
        public AddPlannWindow()
            :this(new PlanningDbService())
        {
        }
        public AddPlannWindow(PlanningDbService userDbService)
        {
            InitializeComponent();
            _planningDbService = userDbService;
            dedlineTimepicker.SelectedDate = DateTime.Today;
        }

        private void CreateNewPlannBtn_Click(object sender, RoutedEventArgs e)
        {
            MyPlann plann = new MyPlann()
            {
                Name = nameTextBox.Text,
                Priority = _selestPriority,
                DedlineDate = dedlineTimepicker.DisplayDate.ToShortDateString().ToString(),
                Information = informationTextBox.Text
            };

            _planningDbService.RegisrateUser(plann);

            Close();
        }

        private void canselBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _selestPriority = (string)(sender as RadioButton).Content;
          
        }
    }
}
