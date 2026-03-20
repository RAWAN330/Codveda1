using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codveda1
{
    class GraduateStudent : Student
    {
        public string ResearchTopic { get; set; }

        public GraduateStudent(string name, int age, string researchTopic)
            : base(name, age)
        {
            ResearchTopic = researchTopic;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Graduate_Student: {Name}, Topic: {ResearchTopic}");
        }
    }
}
