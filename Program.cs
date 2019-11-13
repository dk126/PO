using System;
using System.Runtime.Serialization;

namespace _13._11
{
    class Program
    {
        public class NaszWyjatekExeption : System.Exception
        {
            public NaszWyjatekExeption()
            {
                
            }

            public NaszWyjatekExeption(string message) : base(message)
            {
                message = "Wszystko robisz źle";
                Console.WriteLine(message);
            }

            public NaszWyjatekExeption(string message, Exception innerException) : base(message, innerException)
            {
            }

            public NaszWyjatekExeption(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbe, ktorą chcesz podzielić: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj liczbe, przez jaką chcesz podzielić: ");
                int b = int.Parse(Console.ReadLine());
                var dzielenie = a / b;
                Console.WriteLine(dzielenie);
            }

            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch (OverflowException OverEx)
            {
                Console.WriteLine(OverEx.Message);
            }
            catch (ArithmeticException ArgEx)
            {
                Console.WriteLine(ArgEx.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Coś poszło nie tak:(");
            }
            int aa = 15;
            try
            {
                string a = Console.ReadLine();
                aa = int.Parse(a);
            }
            catch
            {
                Console.WriteLine("Nie zmieniłeś zmiennej- Błąd");
            }
            finally
            {
                Console.WriteLine(aa);
            }
            /*
            StackOverflowException - Wyjątek, który jest generowany w przypadku 
            przepełnienia stosu wykonywania, ponieważ zawiera zbyt wiele wywołań 
            metod zagnieżdżonych.

            NullReferenceException - Wyjątek, który jest generowany, gdy istnieje 
            próba odwołująca się do odwołania do obiektu o wartości null.

            FileNotFoundException - Wyjątek, który jest zgłaszany, gdy nie powiedzie się 
            próba uzyskania dostępu do pliku, który nie istnieje na dysku.

            AccessViolationException - Wyjątek, który jest zgłaszany, gdy podjęto próbę 
            odczytu lub zapisu chronionej pamięci.

            IndexOutOfRangeException - Wyjątek, który jest generowany, gdy zostanie 
            podjęta próba uzyskania dostępu do elementu tablicy lub kolekcji z indeksem, 
            który znajduje się poza granicami.
            */
            try
            {
                Metoda23();
            }
            catch(NotImplementedException NotImpEx)
            {
                Console.WriteLine(NotImpEx.Message);
            }
            Console.ReadKey();
        }
        static void Metoda23()
        {
            throw new NotImplementedException();
        }
    }
}
