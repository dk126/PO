# PO
https://github.com/pio1755/obiektowka
using System;

namespace _11._10._19_1_
{
    public class Car
    {
        private string marka;
        private double rok;
        private string model;
        private double iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;
        public static int iloscKol = 4;   


        public Car(string ma, double r, string mo, double iD, double ps, double ss, int iK)
        {
            marka = ma;
            rok = r;
            model = mo;
            iloscDrzwi = iD;
            pojemnoscSilnika = ps;
            srednieSpalanie = ss;
            iloscKol = iK;
        }
        public Car(string marka, double pojemnoscSilnika)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;           
        }
        public static Car Create(string marka, double pojemnoscSilnika)
        {
            return new Car(marka, pojemnoscSilnika);
        }
      
       
        public void PokazCar()
        {
            Console.WriteLine("{0,-15} {1,10} {2, -15} {3, 10} {4, 10} {5, 10} {6, 10}", marka, rok, model, iloscDrzwi, pojemnoscSilnika, srednieSpalanie, iloscKol);
        }
    }

    class Program
    {      
        
        static void Main(string[] args)
        {
            string carName = "Moj samochod";
            Console.WriteLine(carName);
            Car car1 = new Car("Fiat", 2007, "Panda", 5, 1.4, 8, Car.iloscKol); //deklaracja nowego obiektu
            car1.PokazCar(); //wyswietla car1
            Car car2 = new Car("Honda", 2013, "Civic", 3, 2.0, 6.5, Car.iloscKol);
            car2.PokazCar(); //wyswietla car2
            Car car3 = new Car("Mazda", 1.2);
            Car car4 = Car.Create("Opel", 1.6);
            car3.PokazCar();
            car4.PokazCar();
            //car1 = car2; //nadpisanie wartości car2 do car1
            //car1.PokazCar();
            //car2.PokazCar();

            Console.ReadKey();
        }
    }
}
https://github.com/pio1755/obiektowka?fbclid=IwAR0qR6ojAONW3E5d5YFNnn5gOZG7hub55aqdOAp1HvKKW8Sst5Ihh1gj3GU
KLASA OSOBA I STUDENT:

using System;
using System.Collections.Generic;
using System.Text;

namespace Klasy_21._10
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        private string miejsceZamieszkania;

        public Osoba(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.miejsceZamieszkania = miejsceZamieszkania;
         
        }

        /*public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public int RokUrodzenia
        {
            get { return rokUrodzenia; }
            set { rokUrodzenia = value; }
        }
        */
        public void wypiszOsoba()
        {
            Console.WriteLine("\r\n{0} {1} \r\nRok urodzenia: {2}, Miejsce zamieszkania: {3}", imie, nazwisko, rokUrodzenia, miejsceZamieszkania);
        }
        public void ObliczWiek()
        {
            int wiek = DateTime.Now.Year - this.rokUrodzenia;
            Console.WriteLine("Wiek: {0}", wiek);
        }
    }

    class Student : Osoba
    {
        public int rok;
        public int numerGrupy;
        public int numerAlbumu;

        public Student(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania, int rok, int numerGrupy, int numerAlbumu) : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public void wypiszStudent()
        {
            base.wypiszOsoba();
            Console.WriteLine("Rok studiów: {0} Numer grupy: {1}, \r\nNumer albumu: {2}", rok, numerGrupy, numerAlbumu);
        }
    }

    class StudentPierwszegoRoku : Student
    {
        public StudentPierwszegoRoku(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania, int rok, int numerGrupy, int numerAlbumu) : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania, rok, numerGrupy, numerAlbumu)
        {         
            
        }
        public void wypiszStudent1()
        {
            base.wypiszStudent();
        }
       
    }

}






using System;

namespace Klasy_21._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba Marek = new Osoba("Marek", "Nowak", 1987, "Pasłęk");
            Marek.wypiszOsoba();
            Marek.ObliczWiek();

            Osoba Gabrysia = new Osoba("Gabriela", "Nowak", 1989, "Pasłęk");
            Gabrysia.wypiszOsoba();
            Gabrysia.ObliczWiek();

            Student Piotr = new Student("Piotr", "Kowalczyk", 1995, "Olsztyn", 3, 4, 143546);
            Piotr.wypiszStudent();
            Piotr.ObliczWiek();

            StudentPierwszegoRoku Kasia = new StudentPierwszegoRoku("Katarzyna", "Deptak", 1998, "Warszawa", 1, 5, 127865);
            Kasia.wypiszStudent1();
            Kasia.ObliczWiek();

            Marek = Piotr;
            Kasia = Gabrysia;


            Console.ReadKey();
        }
       
    }
}



