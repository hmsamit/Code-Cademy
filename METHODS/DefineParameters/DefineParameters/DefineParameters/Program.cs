using System;

namespace DefineParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets(9);
            VisitPlanets(8);
            VisitPlanets(4);
        }

        //The VisitPlanets() method has been re-written for you here.

        //Add an int parameter named numberOfPlanets to the method.
        //Change the method body so that it uses the parameter. If someone were to call your method, it should print how many planets they visited. For example, calling VisitPlanets(3) would cause this to be printed:
        //Call VisitPlanets() three times in Main() with different arguments.#9
        static void VisitPlanets(int numberOfPlanets)
        {
            Console.WriteLine($"You visited {numberOfPlanets} planets...");
             
        }
    }
}
