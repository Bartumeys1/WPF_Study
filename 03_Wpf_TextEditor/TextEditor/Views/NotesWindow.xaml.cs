using Microsoft.Win32;
using System;
using System.IO;
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

namespace TextEditor.Views
{
    /// <summary>
    /// Interaction logic for NotesWindow.xaml
    /// </summary>
    public partial class NotesWindow : Window
    {
        public NotesWindow()
        {
            InitializeComponent();
            FilePathInfoLable.Content = "New file.txt";
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        string saveOpenFilter = "All files(*.*)|*.*|Txt files (*.txt)|*.txt|C# file (*.cs)|*.cs||";
        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = saveOpenFilter;
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);

            FilePathInfoLable.Content = saveFileDialog.FileName;
        }

        private void MenuItemCreate_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Text = string.Empty;
            FilePathInfoLable.Content = $"New file.txt";

        }

        private void MenuItemOpen_Click(object sender , RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = saveOpenFilter;
            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            FilePathInfoLable.Content = openFileDialog.FileName;

        }

        private void txtEditor_MouseMove(object sender, MouseEventArgs e)
        {

            cursorPositionInfoLabel.Content = $"{e.GetPosition(txtEditor).X}:{e.GetPosition(txtEditor).Y}";
        }
    }
}
