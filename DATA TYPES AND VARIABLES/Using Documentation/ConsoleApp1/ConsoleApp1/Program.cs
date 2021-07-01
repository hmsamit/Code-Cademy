using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double numberOne = 6.5;
            double numberTwo = 4;

            /* Inside of the first Console.WriteLine() command, raise numberOne to the numberTwo power.
            */
            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne, numberTwo));

            //Inside of the second Console.WriteLine() command, round numberOne up.
            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne));

            //Inside of the third Console.WriteLine() command, find the larger number between numberOne and numberTwo.
            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne, numberTwo));
            Console.ReadKey();
        }
    }
}
