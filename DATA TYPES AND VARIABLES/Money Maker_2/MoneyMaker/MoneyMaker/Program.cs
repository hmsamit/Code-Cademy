using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Greetings
            Console.WriteLine("Welcome to Money Maker!");
            //ask the user for the amount to convert and capture the value in a variable.
            Console.Write("Enter the amount you want to convert to coins: ");
            //Convert the captured value(a string) to a number.
            //You can convert a value using Convert.ToDouble(Console.ReadLine());
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            //EXAMPLE
            //let the user know what you are about to do. For example, if the user entered 16, the program should write to the console:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine($"The amount that you've entered will convert to coins. \n\n\nGold = 10 cents\nSilver = 5 cents \nBronze = 1 cent\n                                         ");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("PRESS ANY KEY TO CONTINUE~");
            Console.ReadLine();
           
            Console.Clear();
          
            
            double goldValue = 10;
            double silverValue = 5;

            //TO GOLD 
            double GoldValue = Math.Floor(amount/ goldValue);
            double ToFindTheRemainingAmount = (GoldValue % goldValue);

            // TO SILVER


            double silverCoins = (amount/silverValue );
            double roundDown = Math.Floor(silverCoins);

            Console.WriteLine("+----------------------------------+");
            Console.WriteLine($"|Amount you entered: { amount}             ");
            Console.WriteLine($"|Gold Coins: {GoldValue}                  ");
            Console.WriteLine($"|Silver Coins: {roundDown}                ");
            Console.WriteLine($"|Bronze Coins: {amount}                   ");
            Console.WriteLine("+----------------------------------+");


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
