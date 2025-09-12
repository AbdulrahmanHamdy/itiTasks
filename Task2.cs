using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI
{
    
struct Time
{
    public int Hours;
    public int Minutes;
    public int Seconds;


    public Time(int h, int m, int s)
    {
        Hours = h;
        Minutes = m;
        Seconds = s;
    }


    public void Print()
    {
        Console.WriteLine($"{Hours:D2}H:{Minutes:D2}M:{Seconds:D2}S");
    }
}
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
            Time t1 = new Time(22, 33, 11);

        t1.Print();
        }
    }
}
