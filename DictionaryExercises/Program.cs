using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string studentName;

            Console.WriteLine("Enter each students name (or ENTER to finish):");

            do
            {
                Console.WriteLine("Student name: ");
                studentName = Console.ReadLine();

                if (!Equals(studentName, ""))
                {
                    Console.WriteLine("Student ID: ");
                    string inputID = Console.ReadLine();
                    int studentID = int.Parse(inputID);
                    students.Add(studentID, studentName);
                }
            } while (!Equals(studentName, ""));

            Console.WriteLine("\nClass Roster:");

            foreach (KeyValuePair<int,string> student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
            }
        }
    }
}
