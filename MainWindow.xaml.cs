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

namespace _27._11_2_
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public double liczba1;
        public double liczba2;
        public double wynik;
        private void ButtonDodawanie_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(ButtonLiczba1.Text);
            liczba2 = Convert.ToDouble(ButtonLiczba2.Text);
            wynik = liczba1 + liczba2;
            ButtonWynik.Text = Convert.ToString(wynik);
        }

        private void ButtonOdejmowanie_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(ButtonLiczba1.Text);
            liczba2 = Convert.ToDouble(ButtonLiczba2.Text);
            wynik = liczba1 - liczba2;
            ButtonWynik.Text = Convert.ToString(wynik);
        }

        private void ButtonMnozenie_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(ButtonLiczba1.Text);
            liczba2 = Convert.ToDouble(ButtonLiczba2.Text);
            wynik = liczba1 * liczba2;
            ButtonWynik.Text = Convert.ToString(wynik);
        }

        private void ButtonDzielenie_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(ButtonLiczba1.Text);
            liczba2 = Convert.ToDouble(ButtonLiczba2.Text);
            wynik = liczba1 / liczba2;
            ButtonWynik.Text = Convert.ToString(wynik);
        }
    }
}
