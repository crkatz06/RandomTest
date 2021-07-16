using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created Instance of Random.
            Random random = new Random();

            // Generated random type, Int.
            int randomInt = random.Next();      
            Console.WriteLine(randomInt);

            // Generated Maximum value of 10, contains numbers 0 to 9.
            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            // Specify minimum and maximum value, Min of 1 & Max of 7, generates random values 1 t0 6.
            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);

            // NextDouble() Method generates random double values. Hover over method name to see a tooltip.
            // It generates a floating-point number from 0.0 up to 1.0.
            double randomDouble = random.NextDouble();

            // Higher random values just need to be multiplied to be reached.
            // To reach random numbers 1 to 100 just multiply by 100.
            Console.WriteLine(randomDouble * 100);

            // Casting converts to other data types.
            // You will notice tiny deviations in precision between float & decimal values each time code is ran.
            Console.WriteLine((float)randomDouble * 100f);
            Console.WriteLine((decimal)randomDouble * 100M);

            // Use max value of 2 simulating a coin toss.
            int zeroOrOne = random.Next(2);

            // Special class for Converting "Convert.ToBoolean()" converts to boolean value, true/false.
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);
        }
    }
}
