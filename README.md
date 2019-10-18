# PO
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
        public static int iloscKol;   


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
            Car car1 = new Car("Fiat", 2007, "Panda", 5, 1.4, 8, 4); //deklaracja nowego obiektu
            car1.PokazCar(); //wyswietla car1
            Car car2 = new Car("Honda", 2013, "Civic", 3, 2.0, 6.5, 4);
            car2.PokazCar(); //wyswietla car2
            Car car3 = new Car("Mazda", 1.2);
            Car car4 = Car.Create("Opel", 1.6);
            car3.PokazCar();
            
            //car1 = car2; //nadpisanie wartości car2 do car1
            //car1.PokazCar();
            //car2.PokazCar();

            Console.ReadKey();
        }
    }
}
