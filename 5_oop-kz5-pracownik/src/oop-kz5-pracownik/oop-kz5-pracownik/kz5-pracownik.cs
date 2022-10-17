using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz5_pracownik
{
    internal class Pracownik
    {
        public class ZbiórPodwładnych : ISet<Pracownik>
        {
            Pracownik przełożony;
            HashSet<Pracownik> zbiór = new HashSet<Pracownik>();
            public HashSet<Pracownik> Zbiór
            {
                get => new HashSet<Pracownik>(zbiór);
            }

            public int Count => ((ICollection<Pracownik>)Zbiór).Count;

            public bool IsReadOnly => ((ICollection<Pracownik>)Zbiór).IsReadOnly;

            public void Add(Pracownik nowy)
            {
                if (zbiór.Contains(nowy))
                    ;
                if (nowy.przełożony != null)
                    nowy.przełożony.Podwładni.Remove(nowy);
                zbiór.Add(nowy);
                nowy.przełożony = przełożony;
            }
            public bool Remove(Pracownik pracownik)
            {
                if (zbiór.Contains(pracownik))
                {
                    pracownik.przełożony = null;
                    zbiór.Remove(pracownik);
                    return true;
                }
                else
                    return false;
            }
            public bool Contains(Pracownik pracownik)
            {
                return zbiór.Contains(pracownik);
            }

            bool ISet<Pracownik>.Add(Pracownik item)
            {
                return ((ISet<Pracownik>)Zbiór).Add(item);
            }

            public void UnionWith(IEnumerable<Pracownik> other)
            {
                ((ISet<Pracownik>)Zbiór).UnionWith(other);
            }

            public void IntersectWith(IEnumerable<Pracownik> other)
            {
                ((ISet<Pracownik>)Zbiór).IntersectWith(other);
            }

            public void ExceptWith(IEnumerable<Pracownik> other)
            {
                ((ISet<Pracownik>)Zbiór).ExceptWith(other);
            }

            public void SymmetricExceptWith(IEnumerable<Pracownik> other)
            {
                ((ISet<Pracownik>)Zbiór).SymmetricExceptWith(other);
            }

            public bool IsSubsetOf(IEnumerable<Pracownik> other)
            {
                return ((ISet<Pracownik>)Zbiór).IsSubsetOf(other);
            }

            public bool IsSupersetOf(IEnumerable<Pracownik> other)
            {
                return ((ISet<Pracownik>)Zbiór).IsSupersetOf(other);
            }

            public bool IsProperSupersetOf(IEnumerable<Pracownik> other)
            {
                return ((ISet<Pracownik>)Zbiór).IsProperSupersetOf(other);
            }

            public bool IsProperSubsetOf(IEnumerable<Pracownik> other)
            {
                return ((ISet<Pracownik>)Zbiór).IsProperSubsetOf(other);
            }

            public bool Overlaps(IEnumerable<Pracownik> other)
            {
                return ((ISet<Pracownik>)Zbiór).Overlaps(other);
            }

            public bool SetEquals(IEnumerable<Pracownik> other)
            {
                return ((ISet<Pracownik>)Zbiór).SetEquals(other);
            }

            public void Clear()
            {
                ((ICollection<Pracownik>)Zbiór).Clear();
            }

            public void CopyTo(Pracownik[] array, int arrayIndex)
            {
                ((ICollection<Pracownik>)Zbiór).CopyTo(array, arrayIndex);
            }

            public IEnumerator<Pracownik> GetEnumerator()
            {
                return ((IEnumerable<Pracownik>)Zbiór).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)Zbiór).GetEnumerator();
            }

            public ZbiórPodwładnych(Pracownik przełożony)
            {
                this.przełożony = przełożony;
            }
        }
        public Pracownik()
        {
            Podwładni = new ZbiórPodwładnych(this);
        }

        public Pracownik przełożony;

        public readonly ZbiórPodwładnych Podwładni;

        public Pracownik BezpośredniPrzełożony // instrukcja ustawiającą nowego przełożonego [wraz z korektą]
        {
            get => przełożony;
            set
            {
                if (przełożony != null)
                    przełożony.Podwładni.Remove(this);
                przełożony = value;
                if (przełożony != null)
                    przełożony.Podwładni.Add(this);
            }
        }

        string
            imię,
            nazwisko,
            imięNazwisko;

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

        /*public Pracownik(string imię, string Nazwisko) // konstruktor
        {
            this.imię = imię;
            this.nazwisko = Nazwisko;
            sklejoneImięNazwisko();
            Podwładni = new ZbiórPodwładnych(this);
        }*/

        public override string ToString() // automatyczna konwersja na stringa, gdy chcemy użyć obiekt zamiast stringa ( do przeładowania )
        {
            return $"{ImięNazwisko}";
        }
    }
}
