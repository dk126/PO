using System;
using System.Threading;

namespace nowy_13._11
{
    class Program
    {
        static void Licz()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("wątek: " + i);
            }
        }
        static void Main(string[] args)
        {
            Thread thr = new Thread(Licz);
            thr.Start();
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("program1: " + i);
            }
            Console.WriteLine();
           
            Console.ReadKey();
        }
    }
}
