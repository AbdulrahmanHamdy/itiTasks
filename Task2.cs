using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI
{
    class Task2
    {
        static void Main()
        {
            Console.Write("Enter number of students:");
            int numStudents = int.Parse(Console.ReadLine());

            string[] students = new string[numStudents];

           
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                students[i] = Console.ReadLine();
            }


            Console.WriteLine("\nList of Students:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student {i + 1}: {students[i]}");
            }
        }
    }
}
