using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz1_osoba
{
    class kz1_osoba
    {
        string imię;
        public string Nazwisko;
        string imięNazwisko; // wartość do konstruktora ImięNazwisko

        public string Imię // instrukcja [konstruktor] deklarująca imię
        {
            get
            {
                return imię;
            }
            set
            {
                imię = value;
                sklejoneImięNazwisko();
            }
        }
        public string Jakieś_Nazwisko // instrukcja [konstruktor] deklarująca nazwisko
        {
            get
            {
                return Nazwisko;
            }
            set
            {
                Nazwisko = value;
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
                    Nazwisko = rozbicie[0];
                else
                    Nazwisko = "";
                sklejoneImięNazwisko();
            }
        }
        void sklejoneImięNazwisko()
        {
            if (Nazwisko != " ")
                imięNazwisko = imię + " " + Nazwisko;
            else
                imięNazwisko = imię;
        }

        public kz1_osoba(string imię, string Nazwisko)
        {
            this.imię = imię;
            this.Nazwisko = Nazwisko;
            sklejoneImięNazwisko();
        }
    }
}
