using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz1_osoba
{
    class Osoba
    {
        string imię;
        string nazwisko;
        string imięNazwisko; // wartość do konstruktora ImięNazwisko


        public DateTime?
            DataUrodzenia,
            DataŚmierci;
        public TimeSpan? wiek_ilośćDni // instrukcja obliczająca wiek
        {
            get
            {
                if (DataŚmierci == null)
                    return DateTime.Now - DataUrodzenia;
                else
                    return DataŚmierci - DataUrodzenia;
            }
        }

        public Osoba() // konstruktor nr 2 [ dotyczy wieku ]
        {
        }


        public string Imię // instrukcja [konstruktor] deklarująca imię
        {
            get
            {
                return imię;
            }
            set
            {
                // sprawdzanie, czy value nie jest puste
                if (value == null)
                    throw new Exception();
                else
                    imię = value;
                sklejoneImięNazwisko();
            }
        }
        public string Nazwisko // instrukcja [konstruktor] deklarująca nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                if (value == null)
                    throw new Exception();
                else
                    nazwisko = value;
                sklejoneImięNazwisko();
            }
        }
        public string ImięNazwisko // instrukcja deklarująca imię oraz nazwisko
        {
            get
            {
                return imięNazwisko;
            }
            set
            {
                string[] rozbicie = value.Split(' ');
                imię = rozbicie[0];
                if (rozbicie.Length > 1)
                    nazwisko = rozbicie[0];
                else
                    nazwisko = "";
                sklejoneImięNazwisko();
            }
        }
        void sklejoneImięNazwisko() // instrukcja łącząca imię i nazwisko
        {
            if (nazwisko != " ")
                imięNazwisko = imię + " " + nazwisko;
            else
                imięNazwisko = imię;
        }

        public Osoba(string imię, string Nazwisko) // konstruktor nr 1 [ dotyczy imienia i nazwiska ]
        {
            this.imię = imię;
            this.nazwisko = Nazwisko;
            sklejoneImięNazwisko();
        }
    }
}
