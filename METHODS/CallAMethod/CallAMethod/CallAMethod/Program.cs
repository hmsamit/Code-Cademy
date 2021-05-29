using System;

namespace CallAMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call Math.Min() with two arguments (any two integers will do). You can view the documentation if you’re not sure how to use this method.
            string msg = "Yabba dabba doo!";
            Math.Min(16, 20);
            //Call Console.WriteLine() using the variable msg as an argument.
            Console.WriteLine(msg);
            //Get the first letter of the msg string using Substring().
            msg.Substring(0,1);


        }
    }
}
