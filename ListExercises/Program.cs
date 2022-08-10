using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            static int SumOfEvenNums(List<int> list)
            {
                int sum = 0;
                foreach (int num in list)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                }
                return sum;
            }

            List<int> nums = new List<int> { 32, 25, 74, 33, 22, 43, 10, 2, 7, 35 };

            Console.WriteLine(SumOfEvenNums(nums));

            static void PrintFiveLetter(List<string> list, int num)
            {
                foreach (string word in list)
                {
                    if (word.Length == num)
                    {
                        Console.WriteLine(word);
                    }
                }
            }

            List<string> words = new List<string> { "hello", "nope", "extended", "fives" };

            Console.WriteLine("Enter the word length for the search: ");
            string input = Console.ReadLine();
            int wordLength = int.Parse(input);

            PrintFiveLetter(words, wordLength);
        }
    }
}
