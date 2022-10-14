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

        public string Imię // instrukcja [konstruktor] deklarująca imię
        {
            get
            {
                return imię;
            }
            set
            {
                // sprawdzić, czy value nie jest puste
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
                nazwisko = value;
                sklejoneImięNazwisko();
            }
        }
        public string ImięNazwisko
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
        void sklejoneImięNazwisko()
        {
            if (nazwisko != " ")
                imięNazwisko = imię + " " + nazwisko;
            else
                imięNazwisko = imię;
        }

        public Osoba(string imię, string Nazwisko)
        {
            this.imię = imię;
            this.nazwisko = Nazwisko;
            sklejoneImięNazwisko();
        }
    }
}
