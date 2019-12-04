using System;
using System.Collections.Generic;

namespace wejsciowka3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pojazd hulajnoga1 = new Hulajnoga("hulajnoga Thunder");
            Pojazd hulajnoga2 = new Hulajnoga("hulajnoga Storm");
            Pojazd cysterna1 = new Cysterna("cysterna BigOne");
            Pojazd cysterna2 = new Cysterna("cysterna LittleOne");
            Queue<string> pojazdy = new Queue<string>();
            pojazdy.Enqueue("hulajnoga Thunder");
            pojazdy.Enqueue("hulajnoga Storm");
            pojazdy.Enqueue("cysterna BigOne");
            pojazdy.Enqueue("cysterna LittleOne");
            foreach (string pojazd in pojazdy)
            {
                Console.WriteLine(pojazd);
            }
            while (pojazdy == null)
            {
                
            }



            Console.ReadKey();

        }
    }
}
