using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hospital_System
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string GetDetails()
        {
            return $"Name: {Name}\n Age: {Age}";
        }
    }
}
