namespace ITI
{
    internal class Task1
    {
        static void Main()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Convert Character to ASCII");
            Console.WriteLine("2. Convert ASCII to Character");
            Console.Write("Enter your choice (1 or 2): ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter a character: ");
                char ch = Console.ReadKey().KeyChar;
                Console.WriteLine($"\nThe ASCII code of '{ch}' is: {(int)ch}");
            }
            else if (choice == 2)
            {
                Console.Write("Enter an ASCII code (0-127): ");
                int ascii = int.Parse(Console.ReadLine());
                char ch = (char)ascii;
                Console.WriteLine($"The character for ASCII code {ascii} is: {ch}");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
            Console.Write("Enter your num: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);


            Console.Write("Enter student degree (0-100): ");
            int degree = int.Parse(Console.ReadLine());

            if (degree >= 90)
                Console.WriteLine("Grade: A");
            else if (degree >= 80)
                Console.WriteLine("Grade: B");
            else if (degree >= 70)
                Console.WriteLine("Grade: C");
            else if (degree >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");


            Console.Write("Enter a number for multiplication table: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMultiplication Table of {num3}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num3} × {i} = {num3 * i}");
            }
        }


    }


    }


