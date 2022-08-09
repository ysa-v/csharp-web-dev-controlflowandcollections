using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string suessQuote = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            string[] suessSplit1 = suessQuote.Split(" ");

            Console.WriteLine(string.Join(",", suessSplit1));

            string[] suessSplit2 = suessQuote.Split(". ");

            Console.WriteLine(string.Join(",", suessSplit2));
        }
    }
}
