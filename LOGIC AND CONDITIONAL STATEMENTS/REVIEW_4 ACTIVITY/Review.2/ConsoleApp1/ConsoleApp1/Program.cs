using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks users to select their favorite fast food and tells them what type of cat they are (or basically, any kind of Buzzfeed style quiz)
            Console.Write("Enter your favorite food: \n");
            Console.WriteLine("A for Jollibe\nB for Chowking\nC for Mang Inasal\nD for McDonald's\nE for Greenwich ");
            
            string FavoriteFastFood = Console.ReadLine();
            Console.Clear();
            switch (FavoriteFastFood)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("+---------------------------+");
                    Console.WriteLine("| You are a Polydactyl cat  |");
                    Console.WriteLine("+---------------------------+");
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("+---------------------------+");
                    Console.WriteLine("|   You are a Snowshoe cat  |");
                    Console.WriteLine("+---------------------------+");
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("+---------------------------+");
                    Console.WriteLine("|    You are a Calico cat   |");
                    Console.WriteLine("+---------------------------+");
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("+---------------------------------+");
                    Console.WriteLine("| You are a British Shorthair cat |");
                    Console.WriteLine("+---------------------------------+");
                    break;
                case "E":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("+---------------------------+");
                    Console.WriteLine("|   You are a Siamese cat   |");
                    Console.WriteLine("+---------------------------+");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("+-------+");
                    Console.WriteLine("| ERROR | ");
                    Console.WriteLine("+-------+");
                    break;
            }
            Console.ReadKey();
        }
    }
}
