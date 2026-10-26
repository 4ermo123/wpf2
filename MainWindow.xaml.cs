
using System.Windows;
using WpfApp3;

namespace AnkietaWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dalej_Click(object sender, RoutedEventArgs e)
        {
            string plec = "";

            if (rbM.IsChecked == true)
                plec = "M";
            else if (rbK.IsChecked == true)
                plec = "K";
            else if (rbI.IsChecked == true)
                plec = "I";

            if (plec == "")
            {
                MessageBox.Show("Wybierz płeć!");
                return;
            }

            WiekKolorWindow okno = new WiekKolorWindow(plec);
            okno.Show();

            Close();
        }
    }
}
