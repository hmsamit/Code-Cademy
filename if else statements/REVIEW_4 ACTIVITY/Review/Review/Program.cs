using System;
using System.Linq;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            CONDITIONALS: if, if...else, else if
            SWITCH STATEMENT: switch (condition)
            TERNARY OPERATOR: (condition) ? true : false

            Good luck! */
            //Has a user guess a random number between 1 - 10 and lets them know if they got it correct, are too low, or are too high

            Console.Write("Guess a random number between 1-10: \n");
            string UserGuessingRandoNumber = Console.ReadLine();
            switch (UserGuessingRandoNumber)
            {
                case "1" :
                    Console.WriteLine("Correct");
                    break;
                case "2":
                    Console.WriteLine("too low");
                    break;
                case "3":
                    Console.WriteLine("Correct");
                    break;
                case "4":
                    Console.WriteLine("too high");
                    break;
                case "5":
                    Console.WriteLine("too low");
                    break;
                case "6":
                    Console.WriteLine("Correct");
                    break;
                case "7":
                    Console.WriteLine("too high");
                    break;
                case "8":
                    Console.WriteLine("too high");
                    break;
                case "9":
                    Console.WriteLine("Correct");
                    break;
                case "10":
                    Console.WriteLine("too low");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;

            }
            Console.ReadKey();


        }
    }
}