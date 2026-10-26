
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AnkietaWPF
{
    public class Ankieta
    {
        public string Plec { get; set; } = "";
        public int Wiek { get; set; }
        public string Kolor { get; set; } = "";

        private static readonly string sciezka =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ankiety.txt");

        public static void Zapisz(Ankieta ankieta)
        {
            string linia = $"{ankieta.Plec};{ankieta.Wiek};{ankieta.Kolor}";

            File.AppendAllText(
                sciezka,
                linia + Environment.NewLine,
                Encoding.UTF8
            );
        }

        public static List<Ankieta> Odczytaj()
        {
            var lista = new List<Ankieta>();

            if (!File.Exists(sciezka))
                return lista;

            foreach (string linia in File.ReadAllLines(sciezka, Encoding.UTF8))
            {
                string[] dane = linia.Split(';');

                if (dane.Length != 3)
                    continue;

                if (!int.TryParse(dane[1], out int wiek))
                    continue;

                lista.Add(new Ankieta
                {
                    Plec = dane[0],
                    Wiek = wiek,
                    Kolor = dane[2]
                });
            }

            return lista;
        }

        public static string SciezkaPliku => sciezka;
    }
}
