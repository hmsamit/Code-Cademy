using System;

namespace ANoteOnParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try causing an error by using the parameter in VisitPlanets() outside of the method body.

            //For example, if your parameter is named numberOfPlanets, you could try to print numberOfPlanets in Main().
            VisitPlanets(numberOfPlanets);
            VisitPlanets(numberOfPlanets);
            VisitPlanets(numberOfPlanets);
        }

        static void VisitPlanets(int numberOfPlanets)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
    }
}
