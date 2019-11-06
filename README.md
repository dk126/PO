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

30.10.2019
using System;

namespace _30._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Honda", "Civic");
            car1.Ride();
            Bicycle bicycle1 = new Bicycle("Thunder", 3000);
            bicycle1.Ride();
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _30._10
{
    interface IRideable
    {
        void Ride();
        
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _30._10
{
    class Vehicle
    {

    }

    class Car : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.Write("Jadę samochodem ");
            Console.WriteLine("{0} {1}", marka, model);
        }
        private string marka;
        private string model;

        public Car(string marka, string model)
        {
            this.marka = marka;
            this.model = model;
        }

    }

    class Bicycle : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.Write("Jadę rowerem ");
            Console.WriteLine("{0} {1}", marka, model);
        }
        private string marka;
        private int model;

        public Bicycle(string marka, int model)
        {
            this.marka = marka;
            this.model = model;
        }
    }
}





using System;

namespace KolejneZadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obiekt1 = new Test();
            Test obiekt2 = new Test();
            Test obiekt3 = new Test();
            obiekt1.liczba = 255;
            obiekt1.poleTestowe.slowo = "słowo";
            obiekt2 = obiekt1;
            obiekt3 = (Test)obiekt1.Clone();
            obiekt1.liczba = 347;
            obiekt1.poleTestowe.slowo = "kaczka";
            Console.WriteLine(obiekt1.liczba);
            Console.WriteLine(obiekt2.liczba);
            Console.WriteLine(obiekt3.liczba);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace KolejneZadanie
{
    class Test2
    {
        public string slowo;

        public Test2(string slowo)
        {
            this.slowo = slowo;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace KolejneZadanie
{
    class Test : IClonable
    {
        public int liczba;
        public Object Clone()
        {
            return MemberwiseClone();
        }
        public Test2 poleTestowe;

        public Test(int liczba, Test2 poleTestowe)
        {
            this.liczba = liczba;
            this.poleTestowe = poleTestowe;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace KolejneZadanie
{
    interface IClonable
    {
        
    }
}
using System;

namespace Orkiestra
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba Uczen = new Osoba("Marek");
            ISkrzypek Uczen2 = new Osoba("Grażynka");
            IGitarzysta Uczen3 = new Osoba("Janusz");
            Uczen.PrzedstawSie();
            Uczen.Graj();
            Console.Write("Jestem Grażynka i ");
            Uczen2.Graj();
            Console.Write("Jestem Janusz i ");
            Uczen3.Graj();
            
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Orkiestra
{
    class Osoba : IGitarzysta, ISkrzypek
    {
        private string imie;

        public Osoba(string imie)
        {
            this.imie = imie;
        }
        public void PrzedstawSie()
        {
            Console.Write("Jestem {0} i ", imie);
        }
        public void Graj()
        {
            Console.WriteLine("gram, ale nie wiem na czym");
            
        }
        void IGitarzysta.Graj()
        {
            Console.WriteLine("gram na gitarze");
        }
        void ISkrzypek.Graj()
        {
            Console.WriteLine("gram na skrzypcach");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Orkiestra
{
    interface ISkrzypek
    {
        void Graj();
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Orkiestra
{
    public interface IGitarzysta
    {
        void Graj();
    }
}

6.11


using System;
using System.Collections.Generic;
using System.Text;

namespace _6._11
{
    class Pracownik
    {
        public string imie { get; private set; }
        public string nazwisko { get; private set; }
        public int wiek{ get; private set; }

        public Pracownik(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public virtual void Pracuj()
        {
            Console.WriteLine("pracownik pracuje");
        }
    }
    class Programista : Pracownik
    {
        public Programista(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
        }

        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiazki programisty");
        }
    }
    class Projektant : Pracownik
    {
        public Projektant(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
        }

        public override void Pracuj()
        {
            Console.WriteLine("Projektant pracuje");
        }
    }
    class Księgowy : Pracownik
    {
        public Księgowy(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
        }

        public override void Pracuj()
        {
            Console.WriteLine("Księgowy pracuje");
        }
    }
}

using System;
using System.Collections.Generic;

namespace _6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pracownik p = new Programista();
            //p.Pracuj();
            
            List<Pracownik> EmployeeList = new List<Pracownik>();
            EmployeeList.Add(new Programista("Staszek", "Dzięcioł", 22));
            EmployeeList.Add(new Projektant("Tomek", "Niemasz", 25));
            EmployeeList.Add(new Księgowy("Krystian", "Gołąb", 24));
           
            foreach (Pracownik Employee in EmployeeList)
            {
                Console.WriteLine("Imie i nazwisko: {0} {1} Wiek: {2}", Employee.imie, Employee.nazwisko, Employee.wiek);
            }
            Console.WriteLine(EmployeeList.Count); //zlicza ilosc obiektow na liscie

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _6._11_2_
{
    abstract public class Figura
    {
        protected int iloscKrawedzi;
        protected int a;
        protected int b;

        protected Figura(int iloscKrawedzi, int a, int b)
        {
            this.iloscKrawedzi = iloscKrawedzi;
            this.a = a;
            this.b = b;
        }
        public abstract int Pole();
        
    }

    internal class Kwadrat : Figura
    {
        public Kwadrat(int iloscKrawedzi, int a, int b) : base(iloscKrawedzi, a, b)
        {
        }

        override public int Pole() { return a * a; }
    }

    internal class Trójkąt : Figura
    {
        public Trójkąt(int iloscKrawedzi, int a, int b) : base(iloscKrawedzi, a, b)
        {
        }

        override public int Pole() { return 1 / 2 * a * b; }
    }
}

using System;

namespace _6._11_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kwadrat = new Kwadrat(0, 3, 0);
            Console.WriteLine(kwadrat.Pole());
            Console.ReadKey();
        }
    }
}




