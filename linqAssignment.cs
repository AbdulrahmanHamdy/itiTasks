using System;
using System.Collections.Generic;
using System.Linq;

namespace ITI
{
    class linqAssignment
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            
            var q1 = numbers.Distinct().OrderBy(n => n);
            Console.WriteLine("Numbers without duplicates & sorted:");
            foreach (var n in q1)
                Console.Write(n + "");
            Console.WriteLine();

       

         
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

          
            var q2_1 = from name in names
                       where name.Length == 3
                       select name;
            var q2_1_method = names.Where(n => n.Length == 3);

            Console.WriteLine("Names with length=3:");
            foreach (var n in q2_1) Console.WriteLine(n);

                       var q2_2 = from name in names
                       where name.ToLower().Contains("a")
                       orderby name.Length
                       select name;
            var q2_2_method = names
                                .Where(n => n.ToLower().Contains("a"))
                                .OrderBy(n => n.Length);

            Console.WriteLine("Names containing 'a' sorted by length:");
            foreach (var n in q2_2) Console.WriteLine(n);

           
            var q2_3 = (from name in names select name).Take(2);
            var q2_3_method = names.Take(2);

            Console.WriteLine("First 2 names:");
            foreach (var n in q2_3) Console.WriteLine(n);

            Console.WriteLine("================================");

            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    ID = 1, FirstName = "Ali", LastName = "Mohammed",
                    subjects = new Subject[]
                    {
                        new Subject(){ Code=22, Name="EF"},
                        new Subject(){ Code=33, Name="UML"}
                    }
                },
                new Student()
                {
                    ID = 2, FirstName = "Mona", LastName = "Gala",
                    subjects = new Subject[]
                    {
                        new Subject(){ Code=22, Name="EF"},
                        new Subject(){ Code=34, Name="XML"},
                        new Subject(){ Code=25, Name="JS"}
                    }
                },
                new Student()
                {
                    ID = 3, FirstName = "Yara", LastName = "Yousf",
                    subjects = new Subject[]
                    {
                        new Subject(){ Code=22, Name="EF"},
                        new Subject(){ Code=25, Name="JS"}
                    }
                },
                new Student()
                {
                    ID = 1, FirstName = "Ali", LastName = "Ali",
                    subjects = new Subject[]
                    {
                        new Subject(){ Code=33, Name="UML"}
                    }
                }
            };

         
            var s1 = students.Select(s => new
            {
                FullName = s.FirstName + " " + s.LastName,
                Count = s.subjects.Length
            });

            Console.WriteLine("Students full name & subject count:");
            foreach (var item in s1)
                Console.WriteLine($"{item.FullName} => {item.Count}");

         
            var s2 = students.OrderByDescending(s => s.FirstName)
                             .ThenBy(s => s.LastName)
                             .Select(s => new { s.FirstName, s.LastName });

            Console.WriteLine("Ordered Students:");
            foreach (var s in s2)
                Console.WriteLine($"{s.FirstName} {s.LastName}");

          
            var s3 = students.SelectMany(
                        s => s.subjects,
                        (st, subj) => new
                        {
                            StudentName = st.FirstName + " " + st.LastName,
                            SubjectName = subj.Name
                        });

            Console.WriteLine("Student and Subjects:");
            foreach (var item in s3)
                Console.WriteLine($"{item.StudentName} => {item.SubjectName}");

     
            var s4 = students.SelectMany(s => s.subjects,
                                         (st, subj) => new { st.FirstName, st.LastName, subj.Name })
                             .GroupBy(x => x.Name);

            Console.WriteLine("Subjects grouped with students:");
            foreach (var grp in s4)
            {
                Console.WriteLine($"Subject: {grp.Key}");
                foreach (var student in grp)
                    Console.WriteLine($"  {student.FirstName} {student.LastName}");
            }
        }
    }

    class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] subjects { get; set; }
    }
}
