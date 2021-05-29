using System;

namespace OptionalParameters
{
    class Program
    {
        //Make the existing parameter in VisitPlanets() optional.
       // The default value should be 0.
        static void Main(string[] args)
        {
           // Call the method without the optional parameter in Main()
            VisitPlanets();
            VisitPlanets();
            VisitPlanets();
        }

        static void VisitPlanets(int numberOfPlanets = 0)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
    }
}