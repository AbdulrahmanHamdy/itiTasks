
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI
{
    class Calc
{
    // Overloaded Sum
    public int Sum(int a, int b) => a + b;
    public double Sum(double a, double b) => a + b;

    // Overloaded Sub
    public int Sub(int a, int b) => a - b;
    public double Sub(double a, double b) => a - b;

    // Overloaded Mul
    public int Mul(int a, int b) => a * b;
    public double Mul(double a, double b) => a * b;

    // Overloaded Div
    public int Div(int a, int b) => a / b;
    public double Div(double a, double b) => a / b;
}

// Base Question class
class Question
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }

    // Constructors
    public Question() { }
    public Question(string header, string body, int mark)
    {
        Header = header;
        Body = body;
        Mark = mark;
    }

    public virtual void Show()
    {
        Console.WriteLine($"[{Header}] ({Mark} Marks)");
        Console.WriteLine(Body);
    }
}

// MCQ Question class inherits from Question
class MCQ : Question
{
    public string[] Choices { get; set; }
    public int CorrectAnswer { get; set; } // index of correct choice

    public MCQ(string header, string body, int mark, string[] choices, int correctAnswer)
        : base(header, body, mark)
    {
        Choices = choices;
        CorrectAnswer = correctAnswer;
    }
    public override void Show()
    {
        base.Show();
        for (int i = 0; i < Choices.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Choices[i]}");
        }
    }
}

    class Task3
    {
        static void Main()
        {
 
        Calc c = new Calc();
        Console.WriteLine("Calc Demo:");
        Console.WriteLine("Sum(5,3) = " + c.Sum(5, 3));
        Console.WriteLine("Mul(2.5, 4) = " + c.Mul(2.5, 4));
        Console.WriteLine();

        
        string[] choices1 = { "Paris", "London", "Rome", "Berlin" };
        MCQ q1 = new MCQ("Q1", "What is the capital of France?", 5, choices1, 1);
        q1.Show();
        Console.WriteLine();

        
        Console.Write("Enter number of MCQs: ");
        int n = int.Parse(Console.ReadLine());
        MCQ[] exam = new MCQ[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter data for Question {i + 1}:");
            Console.Write("Header: ");
            string header = Console.ReadLine();

            Console.Write("Body: ");
            string body = Console.ReadLine();

            Console.Write("Mark: ");
            int mark = int.Parse(Console.ReadLine());

            Console.Write("Number of choices: ");
            int chCount = int.Parse(Console.ReadLine());

            string[] choices = new string[chCount];
            for (int j = 0; j < chCount; j++)
            {
                Console.Write($"Choice {j + 1}: ");
                choices[j] = Console.ReadLine();
            }

            Console.Write("Correct answer (index starting from 1): ");
            int correct = int.Parse(Console.ReadLine());

            exam[i] = new MCQ(header, body, mark, choices, correct);
        }

        Console.WriteLine("\n--- Exam Questions ---");
        foreach (var q in exam)
        {
            q.Show();
            Console.WriteLine();
        }

        
        int total = 0, score = 0;
        foreach (var q in exam)
        {
            q.Show();
            Console.Write("Your answer: ");
            int ans = int.Parse(Console.ReadLine());

            if (ans == q.CorrectAnswer)
                score += q.Mark;

            total += q.Mark;
        }

        Console.WriteLine($"\nYour Score: {score}/{total}");
        }
    }
}
