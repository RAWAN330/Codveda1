using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codveda1
{
    class UndergraduateStudent : Student
    {
        public UndergraduateStudent(string name, int age)
            : base(name, age)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Undergraduate Student: {Name}, Age: {Age}");
        }
    }
}
