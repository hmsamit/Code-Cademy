using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewPasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        //Checks a password if it has uppercase letters and doesn’t include symbols
        {
            Console.Write("Please enter your preffered password for your account: ");
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please make it strong and hard to guess");


        }
    }
}
