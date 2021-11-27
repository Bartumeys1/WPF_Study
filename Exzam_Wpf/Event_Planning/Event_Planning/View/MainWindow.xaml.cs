using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using Event_Planning.Models;
using Event_Planning.Services;

using Event_Planning.View;
namespace Event_Planning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PlanningDbService _planningDbService;
        List<MyPlann> planns;
        public MainWindow()
        {
            InitializeComponent();
            planns = new List<MyPlann>();
            _planningDbService = new PlanningDbService();
            UpdateListView();
        }

        private void UpdateListView()
        {
            planningListView.ItemsSource = null;
            planningListView.Items.Clear();
            planns = _planningDbService.GetData();
            if (planns != null)
                planningListView.ItemsSource = planns;
        }
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPlannWindow addPlannWindow = new AddPlannWindow(_planningDbService);
            addPlannWindow.ShowDialog();

            UpdateListView();

        }

        private void canselBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void serchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(serchTextBox.Text))
            {
                planningListView.ItemsSource = planns;
                return;
            }

            List<MyPlann> res = planns.Where<MyPlann>(el => el.ToString().ToLower().Contains(serchTextBox.Text.ToLower())).ToList();
            if (res != null)
                planningListView.ItemsSource = res;

        }


        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;
        private void planningListView_Click(object sender, RoutedEventArgs e)
        {

            GridViewColumnHeader headerClicked = e.OriginalSource as GridViewColumnHeader;

            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
                {
                    if (headerClicked != _lastHeaderClicked)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        if (_lastDirection == ListSortDirection.Ascending)
                        {
                            direction = ListSortDirection.Descending;
                        }
                        else
                        {
                            direction = ListSortDirection.Ascending;
                        }
                    }



                    string header = headerClicked.Column.Header as string;
                    Sort(header, direction);

                    _lastHeaderClicked = headerClicked;
                    _lastDirection = direction;
                }
            }


        }

        private void Sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView =
              CollectionViewSource.GetDefaultView(planningListView.ItemsSource);

            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }


    }
}
