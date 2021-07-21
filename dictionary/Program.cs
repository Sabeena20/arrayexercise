using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        //private static string newStudent;

        static void Main(string[] args)
        {
            Dictionary<int, String> studentIds = new Dictionary<int, String>();
            int newId = 0;
            String newStudent = "";
            String input = "";

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("ID: ");
                input = Console.ReadLine();
                

                if (!Equals(input, ""))
                {
                    newId = int.Parse(input);
                    Console.WriteLine("Student name: ");
                    input = Console.ReadLine();
                    newStudent = input;
       
                    studentIds.Add(newId, newStudent);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(input, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
            //double sum = 0.0;

            foreach (KeyValuePair<int, String> student in studentIds)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
                //sum += student.Value;
            }

            //double avg = sum / studentIds.Count;
          //  Console.WriteLine("Student ID: " + newId );
         //   Console.WriteLine("Student Name: " + newStudent);
            
        }
    }
}
