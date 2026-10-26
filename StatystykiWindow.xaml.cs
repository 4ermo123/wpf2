
using System.Linq;
using System.Windows;

namespace AnkietaWPF
{
    public partial class StatystykiWindow : Window
    {
        public StatystykiWindow()
        {
            InitializeComponent();
            WyswietlStatystyki();
        }

        private void WyswietlStatystyki()
        {
            // Odczyt danych z pliku
            var ankiety = Ankieta.Odczytaj();

            if (ankiety.Count == 0)
            {
                txtLiczba.Text = "Brak zapisanych ankiet.";
                txtPlec.Text = "";
                txtKolor.Text = "";
                txtWiek.Text = "";
                return;
            }

            txtLiczba.Text =
                $"Liczba ankiet: {ankiety.Count}";

            // Najczęściej wybierana płeć
            var plecGrupy = ankiety
                .GroupBy(a => a.Plec)
                .Select(g => new { Nazwa = g.Key, Liczba = g.Count() })
                .ToList();

            int maxPlec = plecGrupy.Max(g => g.Liczba);

            string plecWynik = string.Join(", ",
                plecGrupy
                    .Where(g => g.Liczba == maxPlec)
                    .Select(g => $"{g.Nazwa} ({g.Liczba} głosów)"));

            txtPlec.Text =
                $"Najczęściej wybierana płeć: {plecWynik}";

            // Najczęściej wybierany kolor
            var kolorGrupy = ankiety
                .GroupBy(a => a.Kolor)
                .Select(g => new { Nazwa = g.Key, Liczba = g.Count() })
                .ToList();

            int maxKolor = kolorGrupy.Max(g => g.Liczba);

            string kolorWynik = string.Join(", ",
                kolorGrupy
                    .Where(g => g.Liczba == maxKolor)
                    .Select(g => $"{g.Nazwa} ({g.Liczba} głosów)"));

            txtKolor.Text =
                $"Najpopularniejszy kolor: {kolorWynik}";

            // Średni wiek
            double sredniWiek = ankiety.Average(a => a.Wiek);

            txtWiek.Text =
                $"Średni wiek: {sredniWiek:F2} lat";
        }

        private void Odswiez_Click(
            object sender, RoutedEventArgs e)
        {
            WyswietlStatystyki();
        }

        private void Zamknij_Click(
            object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
