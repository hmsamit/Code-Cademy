﻿using System;

namespace ReviewMethodCallsAndInput
{
    class Program
    {
        //Make sure you know how to apply all of these concepts before moving on!

        // To pass this last exercise:

        //Call NamePets() with two arguments
       // Call VisitPlanets(), and specify only the numberOfPlanets
        static void Main(string[] args)
        {
            NamePets("Kami", "Kobe");
            NamePets("Cooper", "Kitty ", "Kobe");
            VisitPlanets(numberOfPlanets: 4);
        }

        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }

        static void NamePets(string pet1, string pet2)
        {
            Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
        }

        static void NamePets(string pet1, string pet2, string pet3)
        {
            Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
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
        }

    }
}
