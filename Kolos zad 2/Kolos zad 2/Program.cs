using System;

namespace Kolos_zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Wykładowca wykladowca = new Wykładowca("Andrzej", "Rutkowski", 3);
            Student studentka = new Student("Katarzyna", "Kowalska", 9);
            System users = new System();
            Console.WriteLine(users.GenerujUsera(wykladowca)); 
            Console.WriteLine(users.GenerujUsera(studentka));

            Console.ReadKey();
        }
    }
    abstract class Osoba
    {
        public string Imie;
        public string Nazwisko;
        public int id;

        protected Osoba(string imie, string nazwisko, int id)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            this.id = id;
        }
    }
    class Student : Osoba
    {
        public Student(string imie, string nazwisko, int id) : base(imie, nazwisko, id)
        {
        }
    }
    class Wykładowca : Osoba
    {
        public Wykładowca(string imie, string nazwisko, int id) : base(imie, nazwisko, id)
        {
        }
    }
    class System
    {
        public string GenerujUsera(Osoba o)
        {
            string nick = o.id + "_" + o.Imie.ToLower() + "." + o.Nazwisko.ToLower();
            if (o.GetType().Name == "Wykładowca")
                return "w" + nick;
            else
                return "s" + nick;
        }
    }
}
