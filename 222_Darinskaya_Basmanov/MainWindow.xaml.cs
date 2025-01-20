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

namespace _222_Darinskaya_Basmanov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RadioButton ActiveButton;

        public MainWindow()
        {
            InitializeComponent();
            ActiveButton = RadioButton1;
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TextBox_X.Text);
                double y = Convert.ToDouble(TextBox_Y.Text);

                if (ActiveButton == RadioButton1)
                {
                    double result = Helper.Function(Helper.sh(x), x, y);
                    Result.Text = result.ToString();
                }
                else if (ActiveButton == RadioButton2)
                {
                    double result = Helper.Function(Math.Pow(x, 2), x, y);
                    Result.Text = result.ToString();
                }
                else if (ActiveButton == RadioButton3)
                {
                    double result = Helper.Function(Math.Pow(Math.E, x), x, y);
                    Result.Text = result.ToString();
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(
                            $"{error.Message}",
                            "Ошибка",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                        );
            }
            catch (Exception error)
            {
                MessageBox.Show(
                            $"{error.Message}",
                            "Ошибка",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                        );
            }
        }

        private void Clear_All(object sender, RoutedEventArgs e)
        {
            ActiveButton = RadioButton1;
            ActiveButton.IsChecked = true;

            TextBox_X.Text = string.Empty;
            TextBox_Y.Text = string.Empty;
            Result.Text = string.Empty;
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            ActiveButton = RadioButton1;
        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            ActiveButton = RadioButton2;
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            ActiveButton = RadioButton3;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
                e.Cancel = true;
            base.OnClosing(e);
        }
    }
}
