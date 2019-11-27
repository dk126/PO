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

namespace _27._11
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
        public string imie;        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imie = MyTextBoxPobieranie.Text;
            //MessageBox.Show("Cześć " + this.imie);            
            if (imie != "Wpisz imię" && imie != "")
                MyTextBoxWyświetlanie.Text = "Cześć " + this.imie;
            else
                MessageBox.Show("Coś poszło nie tak:(");
        }

        private void ButtonWyczysc_Click(object sender, RoutedEventArgs e)
        {
            MyTextBoxWyświetlanie.Clear();
        }
    }
}
