using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let’s use string concatenation to tell a story. Come up with a beginning, middle, and end to a story and save them to the corresponding variables beginning, middle, and end.
            string beginning = "Once upon a time,";
            string middle =  "there's an apple tree";
            string end = "with a mango fruit";

            //Concatenate your three strings and store the result in variable named story.
            string story = beginning + ", " + middle + ". " + end + ".";
            /* Print story to the console.
            Are the spacing and punctuation correct? If not, go back and change the story strings so that it prints correctly.
            */
            Console.WriteLine(story);
        }
    }
}
