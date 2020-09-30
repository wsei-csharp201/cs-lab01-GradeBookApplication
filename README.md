# Lab-01. Aplikacja `GradeBook`

Niniejsze zadanie opracowane zostało jako podsumowanie kursu C# opublikowanego na [pluralsight.com](http://www.pluralsight.com). Oryginał zadania dostępny jest na GitHub pod adresem <https://github.com/pluralsight-projects/CSharp-GradeBookApplication>.

Zadanie polega na uzupełnieniu istniejącego kodu projektu aplikacji _Grade Book_ (dziennik ocen) - zgodnie ze szczegółowymi poleceniami, krok po kroku. Poprawność wykonania kolejnych kroków weryfikowana jest wykonaniem testów jednostkowych (framework _xUnit_). Testy opracowane są bardzo zmyślnie - sprawdzają, czy utworzono właściwe pliki we właściwych lokalizacjach i z właściwą zawartością, czy funkcjonalności zostały poprawnie zaimplementowane. W zasadzie nie musisz znać framework'a _xUnit_. Wystarczy, że rozumiesz koncepcję testów jednostkowych.

**Zakres zadania**: fundamenty programowania, klasy i ich składniki, interfejsy i ich implementacje, testy jednostkowe. Poziom _intermediate_.

**Narzędzia**: konto GitHub, Visual Studio 2019 (C#)

**Poświęcony czas**: od 2 do kilkunastu godzin, w zależności od kompetencji i sprawności.

**Szczegółowe polecenia:** [Zadania do wykonania - w języku angielskim (Tasks-to-be-performed.md)](Tasks-to-be-performed.md)

**Zadania do wykonania:**

1. Utwórz _Fork_ tego repozytorium na swoim koncie GitHub.
2. Sklonuj repozytorium na lokalny dysk.
3. Za pomocą Visual Studio 2019 otwórz plik _solution_ `GradeBook.sln`. Solution składa się z projektu aplikacji konsolowej oraz projektu testów jednostkowych. _Solution_ jest wstępnie skonfigurowane.
4. Zaktualizuj rozszerzenia NuGet (prawokliknij na <kbd>Solution Explorer</kbd> → <kbd>Manage NuGet Packages for Solution..</kbd>). Jeśli tego nie zrobisz, prawdopodobnie testy się nie uruchomią.
5. Uruchom <kbd>Test Explorer</kbd> i sprawdź, czy testy się wykonują (oczywiście przy pierwszym uruchomieniu wszystkie zakończą się niepowodzeniem).
6. Wykonuj polecenia z pliku [Tasks-to-be-performed.md](Tasks-to-be-performed.md) kolejno, krok po kroku.
7. Po wykonaniu danego kroku uruchom testy i sprawdź, czy któreś z nich zostały zaakceptowane. Musisz się domyślić, które testy odpowiedzialne są za dany krok. Staraj się zadania wykonywać sekwencyjnie - w podanej przez autora kolejności.
8. Podczas realizowania zadań szczegółowych sięgaj do dokumentacji języka i przypominaj sobie stosowne konstrukcje C#.

Po zakończeniu zadania rozważ opracowanie, na bazie kodu, aplikacji WPF (XAML), obsługującej dziennik ocen.

> Zadanie jest wyjątkowej jakości edukacyjnej. Może być traktowane jako podsumowanie kursu podstawowego lub powtórka materiału przed kursem zaawansowanym.

---

**Zadania dodatkowe (kreatywne):**

1. Rozbuduj logikę i interfejs aplikacji o inne formaty oceniania.
2. Dodaj funkcjonalność automatycznego zapisywania po wykonaniu operacji na danych (dodanie/usunięcie/modyfikacja studenta albo jego ocen).
3. Opracuj wariant aplikacji desktopowej z graficznym interfejsem użytkownika (WPF/XAML).