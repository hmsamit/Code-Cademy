using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program ...
            Author: ...
            */
            Console.WriteLine("Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|       NOW PRESS ANY KEY TO PROCEED      |");
            Console.WriteLine("+-----------------------------------------+");
            Console.ReadLine();
            Console.Clear();

            // Let the user know that the program is starting:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("NOW MAD LIBS IS STARTING! HAVE FUN AND GOOD LUCK!  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|       NOW PRESS ANY KEY TO PROCEED      |");
            Console.WriteLine("+-----------------------------------------+");
            Console.ReadLine();
            Console.Clear();


            // Give the Mad Lib a title:

            Console.ForegroundColor = ConsoleColor.White;
            string title = "TITLE: STORY TIME ";
            Console.WriteLine(title);

            // Define user input and variables:

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            // adj 1
            Console.Write("Enter an adjective for your \"Adjective 1\" :  ");
            string adjective1 = Console.ReadLine();
            // adj2 
            Console.Write("Enter an adjective for your \"Adjective 2\" :  ");
            string adjective2 = Console.ReadLine();
            // adj3
            Console.Write("Enter an adjective for your \"Adjective 3\" :  ");
            string adjective3 = Console.ReadLine();

            // verb 1
            Console.Write("Enter a verb for your \"Verb 1\" : ");
            string verb1 = Console.ReadLine();
            // verb 2
            Console.Write("Enter a verb for your \"Verb 2\" : ");
            string verb2 = Console.ReadLine();
            // verb 3
            Console.Write("Enter a verb for your \"Verb 3\" : ");
            string verb3 = Console.ReadLine();

            // noun 1
            Console.Write("Enter a noun for your \"Noun 1\" : ");
            string noun1 = Console.ReadLine();
            // noun 2
            Console.Write("Enter a noun for your \"Noun 2\" : ");
            string noun2 = Console.ReadLine();

            //10
            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();
            Console.Clear();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2} s ruled the world.";


            // Print the story:

            Console.WriteLine(story);
            Console.ReadLine();
        }
    }
}
