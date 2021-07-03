using System;

namespace MovieScript
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string upperName = name.ToUpper();

            Console.Clear();
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("| Full Name: " + upperName +"|");
            Console.WriteLine("+---------------------------+");
            Console.ReadKey();
            */
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine(cameraDirections + sceneDescription);
            Console.ReadKey();
        }
    }
}
