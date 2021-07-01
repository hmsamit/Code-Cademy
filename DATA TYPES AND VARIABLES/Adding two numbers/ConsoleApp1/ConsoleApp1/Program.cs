using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favorite number: ");
            int faveNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your favorite number 2: ");
            int faveNumber2 = Convert.ToInt32(Console.ReadLine());

            int sum = faveNumber2 + faveNumber2;

            if (sum > 100)
            {
                Console.Clear();
                Console.WriteLine("\nEquivalent of two favourite numbers is greater than 100");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nEquivalent of two favourite numbers is below 100");
            }
            Console.ReadKey();
        }
    }
}
