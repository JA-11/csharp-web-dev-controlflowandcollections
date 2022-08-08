using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> students = new Dictionary<int, string>();

            string newStudent;

            Console.WriteLine("Please enter your students' names and ID numbers (or ENTER to finish):");

            do
            {
                Console.WriteLine("Student Name: ");

                string input = Console.ReadLine();
                newStudent = input;

                if (newStudent != "")
                {
                    Console.WriteLine("ID: ");
                    string userInput = Console.ReadLine();
                    int newID = int.Parse(userInput);
                    students.Add(newID, newStudent);
                }
            } while (!Equals(newStudent, ""));

            
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Value}'s ID: {student.Key}");
            }

            Console.WriteLine($"Number of students in class roster: {students.Count}");

            //Console.WriteLine("Hello World!");
        }
    }
}
