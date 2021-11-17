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

namespace _01_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double lastNumber, res;
        SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
            result.Content = 0;
        }



        private void numbersBtn_Click(object sender, RoutedEventArgs e)
        {
            double selectedValue = 0;

                selectedValue = double.Parse((sender as Button).Content.ToString());

            if (result.Content.ToString() == "0")
            {
                result.Content = $"{selectedValue}";
            }
            else
            {
                result.Content = $"{result.Content}{selectedValue}";
            }

        }



        private void operatorBtn_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(result.Content.ToString(), out lastNumber))
            {
                result.Content = "0";
            }
            
            InfoText.Content = $"{lastNumber}";

            if (sender == plusBtn)
            {
                selectedOperator = SelectedOperator.Addition;
                InfoText.Content += "+";
            }
            else if (sender == minusBtn)
            {
                selectedOperator = SelectedOperator.Substruction;
                InfoText.Content += "-";
            }
            else if (sender == multiplyBtn)
            {
                selectedOperator = SelectedOperator.Multiplication;
                InfoText.Content += "*";
            }
            else if (sender == divisionBtn)
            {
                selectedOperator = SelectedOperator.Divide;
                InfoText.Content += "/";
            }

        }



        private void acBtn_Click(object sender, RoutedEventArgs e)
        {

            result.Content = "0";
            res = 0;
            lastNumber = 0;
            InfoText.Content = "";
        }



        private void negativeBtn_Click(object sender, RoutedEventArgs e)
        {
            double res;
            if (double.TryParse(result.Content.ToString(),out res))
            {
                res *= -1;
                result.Content = res;
            }

        }



        private void percenageBtn_Click(object sender, RoutedEventArgs e)
        {

            lastNumber = double.Parse(result.Content.ToString());
            selectedOperator = SelectedOperator.Persent;
            InfoText.Content = $"{lastNumber}%";
            result.Content = "0";

        }



        private void pointBtn_Click(object sender, RoutedEventArgs e)
        {
            double selectedValue;


            if (double .TryParse(result.Content.ToString(), out selectedValue))
            result.Content = $"{selectedValue},";
           
        }



        private void equalBtn_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;

            if (double.TryParse(result.Content.ToString(), out newNumber))

            {


                switch (selectedOperator)

                {

                    case SelectedOperator.Addition:
                        res = Calculate.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Substruction:
                        res = Calculate.Sub(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        res = Calculate.Mult(lastNumber, newNumber);
                        break;

                    case SelectedOperator.Divide:
                        try
                        {
                            res = Calculate.Divis(lastNumber, newNumber);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error division", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                    case SelectedOperator.Persent:
                        res = lastNumber * double.Parse(result.Content.ToString()) / 100.0D ;
                        break;
                }

                InfoText.Content +=$"{result.Content}" ;
                result.Content = res;
            }
        }



        public enum SelectedOperator
        {
            Addition,
            Substruction,
            Multiplication,
            Divide,
            Persent
        }

    }



    public class Calculate
    {
        public static double Add(double n1, double n2) => n1 + n2;
        public static double Sub(double n1, double n2) => n1 - n2;
        public static double Mult(double n1, double n2) => n1 * n2;
        public static double Divis(double n1, double n2)
        {
            if (n2 == 0)
                throw new Exception("Error devesiond by zero");

            return n1 / n2;
        }
    }
}
