using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        { /*
           1.
            You and your friend are planning a trip together and are trying to decide where to go. You each have specific criteria that it needs to fulfill. You want it to have a beach and city, whereas your friend wants beach or hiking. Your current pick is Barcelona, which is a city that has a beach. Will both you and your friend be happy?

            Create a bool variable named yourNeeds. Write a logical comparison that captures your criteria.
            2.
            Create a bool variable named friendNeeds. Write a logical comparison that captures their criteria.
            3.
            Write a logical comparison that compares yourNeeds and friendNeeds and save it to tripDecision.

            Print tripDecision to the console. Will you agree on Barcelona? You should only go if it satisfies both your needs and your friend’s needs.

            What about Portbou, a smaller town (not a city) with a beach but no hiking?
           */
            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = beach && city;
            bool friendNeeds = beach || hiking;

            bool tripDecision = yourNeeds && friendNeeds;

            Console.WriteLine(tripDecision);

            Console.ReadKey();
        }
    }
}


