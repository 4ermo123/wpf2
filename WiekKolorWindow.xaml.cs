
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp3;

namespace AnkietaWPF
{
    public partial class WiekKolorWindow : Window
    {
        private readonly string wybranaPlec;

        public WiekKolorWindow(string plec)
        {
            InitializeComponent();
            wybranaPlec = plec;
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtWiek.Text, out int wiek)
                || wiek < 1 || wiek > 120)
            {
                MessageBox.Show("Podaj prawidłowy wiek od 1 do 120.");
                return;
            }

            if (cmbKolor.SelectedItem is not ComboBoxItem item)
            {
                MessageBox.Show("Wybierz kolor.");
                return;
            }

            string kolor = item.Content.ToString()!;

            Ankieta.Zapisz(new Ankieta
            {
                Plec = wybranaPlec,
                Wiek = wiek,
                Kolor = kolor
            });

            MessageBox.Show(
                $"Ankieta została zapisana!\nPlik: {Ankieta.SciezkaPliku}"
            );

            txtWiek.Clear();
            cmbKolor.SelectedIndex = 0;
        }

        private void Statystyki_Click(object sender, RoutedEventArgs e)
        {
            StatystykiWindow okno = new StatystykiWindow();
            okno.ShowDialog();
        }
    }
}
