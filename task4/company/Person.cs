using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI
{

    static class IdGenerator
    {
        private static int currentId = 0;
        public static int GenerateId() => ++currentId;
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age, int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
        public abstract void Introduce();
    }
}

