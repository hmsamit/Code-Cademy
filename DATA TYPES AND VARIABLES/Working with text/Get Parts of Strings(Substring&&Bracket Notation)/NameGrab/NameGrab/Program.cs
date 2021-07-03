using System;

namespace NameGrab
{
    class Program
    {
        static void Main(string[] args)
        {  /*
            string plantName = "Heizel Mae S. Amit";
            int charPosition = plantName.IndexOf("t"); // returns 15
            char u = plantName[charPosition]; // returns u
            */
            string name = "Farhad Hesam Abbasi";
            int firstName = name.IndexOf("F");
            char firstLetter = name[firstName];

            int lastname1 = name.IndexOf("Abbasi");
            string lastName = name.Substring(lastname1);

            Console.WriteLine($"Full Name: " + name + "\nFirst letter of the name: " +firstLetter);
            Console.WriteLine($"Last name: " +lastName);
            Console.ReadKey();
        }
    }
}