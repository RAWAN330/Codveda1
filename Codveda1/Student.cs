using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codveda1
{
    class Student
    {
        public string Name { get; set; }
       // public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
          
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

      
            private int age;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0)
                        age = value;
                }
            }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying...");
        }
    }
}
