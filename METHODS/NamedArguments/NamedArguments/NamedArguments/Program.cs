using System;

namespace NamedArguments
{
    //The VisitPlanets() method has some new optional parameters.
    //First, call the method in Main() with no arguments.

    //Call the method again, but define only the numberOfPlanets parameter as 2.

    //Call the method one more time, now defining the numberOfPlanets as 2 and name with your name.
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets(name: "Cosmonaut", numberOfPlanets: 2);;
        }

        static void VisitPlanets(
          string adjective = "brave",
          string name = "Cosmonaut",
          int numberOfPlanets = 0,
          double gForce = 4.2)
        {
            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
            Console.ReadKey();  
        }
       
    }
}
