📝 Ankieta WPF
Aplikacja desktopowa napisana w języku C# z wykorzystaniem technologii WPF (Windows Presentation Foundation). Umożliwia przeprowadzanie ankiet, zapisywanie odpowiedzi do pliku tekstowego oraz generowanie statystyk.

✨ Funkcjonalności
👤 Wybór płci: M, K lub I.
🎂 Wprowadzenie wieku ankietowanego.
🎨 Wybór jednego z 10 kolorów.
💾 Zapis odpowiedzi do pliku ankiety.txt.
📂 Odczyt zapisanych danych z pliku.
📊 Generowanie statystyk ankiety.
🏆 Wyznaczanie najczęściej wybieranej płci i koloru.
🧮 Obliczanie średniego wieku ankietowanych.
🔄 Odświeżanie statystyk na podstawie zapisanych danych.
✅ Walidacja wprowadzonego wieku.
🛠️ Technologie
C#
WPF
XAML
.NET 8 lub nowszy
🎨 Dostępne kolory
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
└── README.md
🚀 Uruchomienie projektu
Wymagania
System Windows.
Visual Studio z obsługą WPF.
.NET 8 SDK lub nowszy, zgodny z konfiguracją projektu.
Instrukcja uruchomienia
Sklonuj repozytorium:

bash
git clone <URL_REPOZYTORIUM>
Otwórz plik .sln lub .csproj w Visual Studio.
Zbuduj projekt, wybierając Build → Build Solution.
Uruchom aplikację za pomocą klawisza F5 lub Ctrl + F5.
📋 Jak działa aplikacja?
Użytkownik wybiera płeć w pierwszym oknie.
Przechodzi do drugiego okna.
Podaje swój wiek i wybiera ulubiony kolor.
Zapisuje odpowiedzi do pliku tekstowego.
Może wyświetlić statystyki wszystkich zapisanych ankiet.
💾 Zapis danych
Odpowiedzi są zapisywane w pliku ankiety.txt.

Każda linia zawiera dane jednej osoby w formacie:


text
Płeć;Wiek;Kolor
Przykładowe dane:


text
M;25;Niebieski
K;31;Czarny
I;20;Zielony
M;40;Niebieski
K;25;Czerwony
Dane są oddzielone średnikami (;). Nowe odpowiedzi są dopisywane do pliku, dzięki czemu wcześniejsze wyniki pozostają zapisane.

📊 Statystyki
Program oblicza:

Liczbę ankiet – liczbę poprawnie odczytanych odpowiedzi.
Najczęściej wybieraną płeć – opcję z największą liczbą głosów.
Najpopularniejszy kolor – kolor wskazany przez największą liczbę osób.
Średni wiek – średnią arytmetyczną wieku wszystkich ankietowanych.
W przypadku remisu program wyświetla wszystkie opcje z największą liczbą głosów.

Przykładowy wynik
Dla pięciu przykładowych ankiet:


Statystyka	Wynik
Liczba ankiet	5
Najczęściej wybierana płeć	M i K – po 2 głosy
Najpopularniejszy kolor	Niebieski – 2 głosy
Średni wiek	28,20 lat
Wzór na średni wiek
S
ˊ
redni wiek
=
Suma wieku
Liczba ankiet
🔐 Przechowywanie danych
Dane są zapisywane lokalnie na komputerze.
Aplikacja nie wymaga połączenia z internetem.
Plik ankiety.txt jest tworzony automatycznie podczas zapisu pierwszej ankiety.
Usunięcie pliku powoduje utratę zapisanych danych.
🎯 Cel projektu
Celem projektu jest praktyczne wykorzystanie:

tworzenia interfejsów graficznych w WPF,
obsługi zdarzeń i kontrolek XAML,
przekazywania danych między oknami,
zapisu i odczytu plików w C#,
przetwarzania kolekcji danych za pomocą LINQ,
obliczania statystyk na podstawie zebranych odpowiedzi.
📄 Licencja
Projekt edukacyjny przeznaczony do nauki programowania w języku C# i technologii WPF.
