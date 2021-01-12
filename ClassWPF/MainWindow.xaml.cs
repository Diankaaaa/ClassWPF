using ClassWPF.Model;
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

namespace ClassWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double real = double.Parse(a1.Text);
            double imaginary = double.Parse(b1.Text);

            Complex_number a = new Complex_number(real, imaginary);
            OUTPUT.Text += "Модуль: " + a.ABC() + Environment.NewLine + "Обратное число: " + a.getReverseNumberA() + " " + a.getReverseNumberB() + Environment.NewLine + Environment.NewLine;
        }

        //Очистка поля вывода результата
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OUTPUT.Text = String.Empty;
        }

        //Ввод только цифр
        private void a1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void b1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
