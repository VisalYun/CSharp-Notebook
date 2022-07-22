using System;

namespace Variable
{
    public class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Visal";
            bool isWorking = true;

            var implicitVar = "Hello";

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(implicitVar);

            Console.WriteLine("{0} {1}", "This is Format string", "where argument is pass after the format string and go to repective placeholder");

            const float Pi = 3.14f;
            Console.WriteLine(Pi);

            // explicit cast
            byte @byte = 1;
            int @int = @byte;
            Console.WriteLine(@int);

            // implicit cast
            int i1 = 1000;
            byte b1 = (byte) i1;
            Console.WriteLine(b1);

            var a = 1;
            var b = 2.2f;
            var c = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);
        }
    }
}