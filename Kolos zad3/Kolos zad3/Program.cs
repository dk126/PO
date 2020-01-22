using System;

namespace Kolos_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lody kupuje = new Włoskie();
            kupuje = new CzekoladaDekorator(kupuje);
            kupuje = new PosypkaKolorowaDekorator(kupuje);
            Console.WriteLine("Kupuję " + kupuje.Opis() + "za " + kupuje.Koszt() + " zł");
            Lody kupuje2 = new Gałkowe();
            kupuje2 = new MorelowaDekorator(kupuje2);
            Console.WriteLine("Kupuję " + kupuje2.Opis() + "za " + kupuje2.Koszt() + " zł");
            double suma = kupuje.Koszt() + kupuje2.Koszt();
            Console.WriteLine("Łączny koszt: " + suma + " zł");
            
            Console.ReadKey();
        }
        public abstract class Lody
        {
            public abstract double Koszt();
            public abstract string Opis();
        }
        public class Gałkowe : Lody
        {
            public override double Koszt()
            {
                return 3.00;
            }
            public override string Opis()
            {
                return "lody gałkowe ";
            }
        }
        public class Włoskie : Lody
        {
            public enum Smak { Śmietankowe, Czekoladowe };
            public string jakiSmaks()
            {
                return Convert.ToString(Smak.Śmietankowe);
            }
            public string jakiSmakcz()
            {
                return Convert.ToString(Smak.Czekoladowe);
            }
            public override double Koszt()
            {
                return 5.00;
            }
            public override string Opis()
            {
                return "lody włoskie ";
            }
        }
        class DekoratorLodówWłoskich : Lody
        {
            protected Lody _lody;
            public DekoratorLodówWłoskich(Lody lody)
            {
                _lody = lody;
            }
            public override double Koszt()
            {
                return _lody.Koszt();
            }

            public override string Opis()
            {
                return _lody.Opis();
            }
        }
        class DekoratorLodówGałkowych : Lody
        {
            protected Lody _lody;
            public DekoratorLodówGałkowych(Lody lody)
            {
                _lody = lody;
            }
            public override double Koszt()
            {
                return _lody.Koszt();
            }

            public override string Opis()
            {
                return _lody.Opis();
            }
        }
        class CzekoladaDekorator : DekoratorLodówWłoskich
        {
            public CzekoladaDekorator(Lody lody) : base(lody)
            {

            }

            public override double Koszt()
            {
                return base.Koszt() + 0.50;
            }

            public override string Opis()
            {
                return base.Opis() + "z polewą czekoladową ";
            }
        }
        class PolewaOwocowaDekorator : DekoratorLodówWłoskich
        {
            public PolewaOwocowaDekorator(Lody lody) : base(lody)
            {

            }

            public override double Koszt()
            {
                return base.Koszt() + 0.80;
            }

            public override string Opis()
            {
                return base.Opis() + "z polewą owocową ";
            }
        }
        class PosypkaKolorowaDekorator : DekoratorLodówWłoskich
        {
            public PosypkaKolorowaDekorator(Lody lody) : base(lody)
            {

            }

            public override double Koszt()
            {
                return base.Koszt() + 0.50;
            }

            public override string Opis()
            {
                return base.Opis() + "z posypką kolorową ";
            }
        }
        class CytrynowaDekorator : DekoratorLodówGałkowych
        {
            public CytrynowaDekorator(Lody lody) : base(lody)
            {

            }

            public override double Koszt()
            {
                return base.Koszt() + 0.20;
            }

            public override string Opis()
            {
                return base.Opis() + "o smaku cytrynowym ";
            }
        }
        class ŚmietankowaDekorator : DekoratorLodówGałkowych
        {
            public ŚmietankowaDekorator(Lody lody) : base(lody)
            {

            }

            public override double Koszt()
            {
                return base.Koszt() + 0.20;
            }

            public override string Opis()
            {
                return base.Opis() + "o smaku śmietankowym ";
            }
        }
        class BakaliowaDekorator : DekoratorLodówGałkowych
        {
            public BakaliowaDekorator(Lody lody) : base(lody)
            {

            }

            public override double Koszt()
            {
                return base.Koszt() + 0.20;
            }

            public override string Opis()
            {
                return base.Opis() + "o smaku bakaliowym ";
            }
        }
        class MorelowaDekorator : DekoratorLodówGałkowych
        {
            public MorelowaDekorator(Lody lody) : base(lody)
            {

            }

            public override double Koszt()
            {
                return base.Koszt() + 0.20;
            }

            public override string Opis()
            {
                return base.Opis() + "o smaku morelowym ";
            }
        }
    }
}
