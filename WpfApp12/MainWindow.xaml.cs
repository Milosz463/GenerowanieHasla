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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string haslo = "";
        int losowa;
        string litera = "abcdefghijklmnoprstuwyzx";
        string znakiSpecjalne = "!@#$%^&*()_+-=";

        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imiona=imie.Text;
            string nazwiska = nazwisko.Text;
            string wybor = stanowiska.Text;
            if(wybor== "Kierownik")
            {
                MessageBox.Show("Dane pracownika: "+imiona+" " + nazwiska +" "+ "Kierwonik");
            }
            else if (wybor == "Starszy programista")
            {
                MessageBox.Show("Dane pracownika: " + imiona + " " + nazwiska + " " + "Starszy programista");
            }
            else if (wybor == "Mlodszy programista")
            {
                MessageBox.Show("Dane pracownika: " + imiona + " " + nazwiska + " " + "Mlodszy programista");
            }
            else if (wybor == "Tester")
            {
                MessageBox.Show("Dane pracownika: " + imiona + " " + nazwiska + " " + "Tester");
            }
            else
            {
                MessageBox.Show("Podaj swoje stanowisko");
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
           generuHaslo();
        }

        void generuHaslo()
        {
            
            
            if (litery.IsChecked == true)
            {
                string litera = "abcdefghijklmnoprstuwyzx";
                int losowaLitera = random.Next(litera.Length);
                haslo = haslo + litera[losowaLitera];
                
            }
            if(cyfry.IsChecked == true)
            {
                int losowaCyfra = random.Next(10);
                haslo = haslo + losowaCyfra.ToString();
                
            }
            if (cyfry.IsChecked == true)
            {
                int losowyZnak = random.Next(znakiSpecjalne.Length);
                haslo = haslo + znakiSpecjalne[losowyZnak];

            }
            MessageBox.Show("haslo" + haslo);
        }
    }
}
