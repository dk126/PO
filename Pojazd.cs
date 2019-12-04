using System;
using System.Collections.Generic;
using System.Text;

namespace wejsciowka3
{
    public abstract class Pojazd : ISkladany
    {
        protected string nazwa;

        protected Pojazd(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public void Rozloz()
        {
            Console.WriteLine("Rozkladam {0}", this.nazwa);
        }

        public void Zloz()
        {
            Console.WriteLine("Skladam {0}", this.nazwa);
        }

        void Jedz()
        {          
            Console.WriteLine("{0} jedzie!", this.GetType().Name);
        }
    }
    internal class Hulajnoga : Pojazd, ISkladany
    {
        public Hulajnoga(string nazwa) : base(nazwa)
        {
        }
    }
    internal class Cysterna : Pojazd
    {
        public Cysterna(string nazwa) : base(nazwa)
        {
        }
    }
}
