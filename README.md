📝 Ankieta WPF – C#
Aplikacja desktopowa napisana w języku C# z wykorzystaniem technologii WPF (Windows Presentation Foundation). Program umożliwia przeprowadzenie ankiety, zapis odpowiedzi do pliku tekstowego oraz generowanie statystyk na podstawie zebranych danych.

📌 Funkcjonalności
Wybór płci – użytkownik wybiera jedną z trzech opcji: M, K lub I.
Podanie wieku – aplikacja sprawdza poprawność wprowadzonego wieku (od 1 do 120 lat).
Wybór ulubionego koloru – dostępnych jest 10 kolorów:
Czarny
Biały
Czerwony
Niebieski
Zielony
Żółty
Pomarańczowy
Fioletowy
Różowy
Szary
Zapis danych – odpowiedzi są zapisywane w pliku ankiety.txt.
Odczyt danych – aplikacja odczytuje zapisane ankiety, również po ponownym uruchomieniu programu.
Statystyki – program oblicza:
liczbę zapisanych ankiet,
najczęściej wybieraną płeć,
najpopularniejszy kolor,
średni wiek ankietowanych.
Obsługa remisów – w przypadku takiej samej liczby głosów dla kilku opcji wyświetlane są wszystkie zwycięskie opcje.
🛠️ Technologie
C#
WPF (Windows Presentation Foundation)
.NET 8 lub nowszy
XAML
Plik tekstowy do przechowywania danych
📂 Struktura projektu

text
AnkietaWPF/
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── WiekKolorWindow.xaml
├── WiekKolorWindow.xaml.cs
├── StatystykiWindow.xaml
├── StatystykiWindow.xaml.cs
├── Ankieta.cs
├── ankiety.txt
└── README.md
Plik ankiety.txt jest tworzony automatycznie przy pierwszym zapisie odpowiedzi. Jego lokalizacja zależy od katalogu uruchomieniowego aplikacji.
🚀 Uruchomienie
Wymagania
System Windows.
Visual Studio z zainstalowanym pakietem tworzenia aplikacji .NET Desktop.
.NET 8 SDK lub nowszy, zgodny z konfiguracją projektu.
Instrukcja
Sklonuj repozytorium:

bash
git clone <URL_REPOZYTORIUM>
Otwórz plik rozwiązania .sln lub projekt .csproj w Visual Studio.
Upewnij się, że projekt korzysta z WPF i odpowiedniej wersji .NET.
Zbuduj projekt za pomocą opcji Build → Build Solution.
Uruchom aplikację klawiszem F5 lub Ctrl + F5.
📖 Jak korzystać z aplikacji?
Uruchom program.
W pierwszym oknie wybierz płeć: M, K lub I.
Kliknij przycisk Dalej.
W drugim oknie podaj wiek i wybierz ulubiony kolor.
Kliknij Zapisz ankietę.
Aby wyświetlić statystyki, kliknij Pokaż statystyki.
W razie potrzeby użyj przycisku Odśwież statystyki, aby ponownie odczytać dane z pliku.
💾 Format zapisu danych
Każda ankieta jest zapisywana w osobnym wierszu pliku ankiety.txt.

Format:


text
Płeć;Wiek;Kolor
Przykładowe dane:


text
M;25;Niebieski
K;31;Czarny
I;20;Zielony
M;40;Niebieski
K;25;Czerwony
Dane są rozdzielone średnikami (;). Nowe odpowiedzi są dopisywane do pliku, dzięki czemu wcześniejsze ankiety nie są nadpisywane.

📊 Przykładowe statystyki
Dla powyższych danych program wyświetli:

Liczba ankiet: 5
Najczęściej wybierana płeć: M i K – po 2 głosy
Najpopularniejszy kolor: Niebieski – 2 głosy
Średni wiek ankietowanych: 28,20 lat
🧮 Obliczanie średniego wieku
Średni wiek obliczany jest na podstawie wszystkich poprawnie odczytanych ankiet:

S
ˊ
redni wiek
=
Suma wieku ankietowanych
Liczba ankietowanych
Wynik jest wyświetlany z dokładnością do dwóch miejsc po przecinku.

🔒 Przechowywanie danych
Dane są przechowywane lokalnie w pliku tekstowym.
Aplikacja nie wymaga połączenia z internetem.
Plik należy chronić przed nieautoryzowanym dostępem, jeśli zawiera rzeczywiste dane ankietowanych.
Usunięcie pliku ankiety.txt spowoduje utratę zapisanych odpowiedzi.
👨‍💻 Autor
Projekt edukacyjny demonstrujący tworzenie aplikacji okienkowej WPF, obsługę kontrolek XAML, zapis i odczyt plików oraz analizę danych w języku C#.

📄 Licencja
Projekt może być wykorzystywany do nauki programowania i rozwijany na własne potrzeby. W przypadku publikacji warto dodać odpowiednią licencję, np. MIT.