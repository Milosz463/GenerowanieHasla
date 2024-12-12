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
       
        public MainWindow()
        {
            InitializeComponent();
        }
private void Button_Click(object sender, RoutedEventArgs e)
{
    string imiona = imie.Text;
    string nazwiska = nazwisko.Text;
    string wybor = stanowiska.Text;
    if (wybor == "Kierownik")
    {
        MessageBox.Show("Dane pracownika: " + imiona + " " + nazwiska + " " + "Kierwonik"+" " + "haslo:"+" " + haslo);
    }
    else if (wybor == "Starszy programista")
    {
        MessageBox.Show("Dane pracownika: " + imiona + " " + nazwiska + " " + "Starszy programista"+" " + "haslo: " + " " + haslo);
    }
    else if (wybor == "Mlodszy programista")
    {
        MessageBox.Show("Dane pracownika: " + imiona + " " + nazwiska + " " + "Mlodszy programista"+" " + "haslo: " + " " + haslo);
    }
    else if (wybor == "Tester")
    {
        MessageBox.Show("Dane pracownika: " + imiona + " " + nazwiska + " " + "Tester"+" " + "haslo: "+" " + haslo);
    }
    else
    {
        MessageBox.Show("Podaj swoje stanowisko");
    }
}


private void Button_Click_1(object sender, RoutedEventArgs e)
{
    haslo = "";
    int dlugosc = 0;
    Random random = new Random();
    if (int.TryParse(znakii.Text, out dlugosc))
    {
        if (litery.IsChecked == true)
        {
            string litera = "abcdefghijklmnoprstuwyzx";
            int indeks = random.Next(litera.Length);
            haslo = haslo + litera[indeks];

        }
        if (cyfry.IsChecked == true)
        {
            int losowaCyfra = random.Next(10);
            haslo = haslo + losowaCyfra.ToString();

        }
        if (znaki.IsChecked == true)
        {
            string znakiSpecjalne = "!@#$%^&*()_+-=";
            int indeks = random.Next(znakiSpecjalne.Length);
            haslo = haslo + znakiSpecjalne[indeks];

        } 
        while (haslo.Length < dlugosc)
        {
            string male = "qwertyuiopasdfghjklzxcvbnm";
            int indeks = random.Next(male.Length);
            haslo += male[indeks];
        }
        MessageBox.Show("haslo: " + haslo);

    }
}
       
    }
}
