using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using multiple else if statements can get unwieldy pretty quickly.Imagine writing an else if statement for every possible number of guests.And you invited 20 people.You have to  write a lot of repetitive code, which is hard to read and prone to errors.

            // If it’s necessary to evaluate several conditions with their own unique output, a switch statement is the way to go. Switch statements allow for compact control flow structures by evaluating a single expression and executing code blocks based on a matched case.
            //You want to build a simple movie recommender that gives the top movie in a particular genre.

            // First, create a string variable named genre and save the value "Horror" to it.
            Console.Write("Genre: ");
            string genre = Console.ReadLine();
            //Create a switch statement using genre. 
            switch (genre)
            {
                //Next, add the following movie genres as cases to the switch statement. Make sure to also add a default case. Add a break statement to each case.
                // after that....
                //Next, add Console.WriteLine() statements to each case in the switch statement so that the program prints out different movie titles based on the selected genre. For the default case, print “No movie found”.

                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;
                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;
                case "Adventure":
                    Console.WriteLine("King Kong");
                    break;
                case "Horror":
                    Console.WriteLine("Psycho");
                    break;
                case "Science Fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;
                default:
                    Console.WriteLine("No Movie Found");
                    break;

            }
            Console.ReadKey();

        }
    }
}
