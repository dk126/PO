using System;
using System.Collections.Generic;

namespace Kolos
{
    class Program
    {
        static void Main(string[] args)
        {
            Liga Ekstraklasa = new Liga("Ekstraklasa");
            Druzyna Stomil = new Druzyna(Ekstraklasa, "Stomil Olsztyn");
            Ekstraklasa.DodajDruzyne(Stomil);
            Zawodnik Czesiek = new Zawodnik(1, "Czesław Szybki", Pozycja.Pomocnik, 40000);
            Zawodnik Marian = new Zawodnik(2, "Marian Mariański", Pozycja.Bramkarz, 67000);
            Zawodnik Janusz = new Zawodnik(3, "Janusz Kowalski", Pozycja.Obrońca, 21500);
            Zawodnik Krzysiek = new Zawodnik(4, "Krzysztof Piątek", Pozycja.Napastnik, 100000);
            Stomil.DodajZawodnika(Czesiek);
            Stomil.DodajZawodnika(Marian);
            Stomil.DodajZawodnika(Janusz);
            Stomil.DodajZawodnika(Krzysiek);
            Console.WriteLine(Stomil.ObliczWartosc(Czesiek, Marian, Janusz, Krzysiek));

            Console.ReadKey();

        }
    }
    class Liga
    {
        public List<Druzyna> druzyny = new List<Druzyna>();
        public string Nazwa;

        public Liga(string nazwa)
        {
            Nazwa = nazwa;
        }
        public void DodajDruzyne(Druzyna d)
        {
            druzyny.Add(d);
        }
    }
    class Druzyna
    {
        public Liga liga;
        public string Nazwa;
        public List<Zawodnik> zawodnicy = new List<Zawodnik>();

        public Druzyna(Liga liga, string nazwa)
        {
            this.liga = liga;
            Nazwa = nazwa;
        }
        public void DodajZawodnika(Zawodnik z)
        {
            zawodnicy.Add(z);
        }

        public double ObliczWartosc(Zawodnik a, Zawodnik b, Zawodnik c, Zawodnik d)
        {
            double wynik = a.wartosc + b.wartosc + c.wartosc + d.wartosc;
            return wynik;
        }
    }
    class Zawodnik
    {
        public long id;
        public string Name;
        public Pozycja pozycja;
        public double wartosc;

        public Zawodnik(long id, string name, Pozycja pozycja, double wartosc)
        {
            this.id = id;
            Name = name;
            this.pozycja = pozycja;
            this.wartosc = wartosc;
        }
    }
    enum Pozycja    { Bramkarz, Obrońca, Pomocnik, Napastnik }
}
