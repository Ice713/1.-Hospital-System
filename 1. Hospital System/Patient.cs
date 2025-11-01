using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hospital_System
{
    internal class Patient : Person
    {
        public string Disease { get; set; }
        public Patient(string name, int age, string disease) : base(name, age)
        {
            Disease = disease;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $"\n Disease: {Disease}";
        }
    }
}
