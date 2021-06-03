using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amit_HeizelMaeAssessment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Show the code in creating a list of Persons then add the following Person with names: “Juno”, “Minerva”, and “Ceres”, lastly remove Minerva from the list.";


            List<string> Name = new List<string>();

            //Show the code in creating a list of Persons then add the following Person with names: “Juno”, “Minerva”, and “Ceres”
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NAME LIST: \n");
            Console.ForegroundColor = ConsoleColor.White;
            Name.Add("Juno");
            Name.Add("Minerva");
            Name.Add("Ceres");

            for (int i = 0; i < Name.Count; i++)
            {
                Console.WriteLine(Name[i]);
            }

            // lastly remove Minerva from the list.
            Name.RemoveAt(1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n+--------------------------------+");
            Console.WriteLine("|       UPDATED NAME LIST:       |");
            Console.WriteLine("+--------------------------------+\n");
            Console.ForegroundColor = ConsoleColor.White;
            //and we can do for loop again or copy the loop above
            for (int i = 0; i < Name.Count; i++)
            {
                Console.WriteLine(Name[i]);
            }

            Console.ReadKey();

        }
    }
}
