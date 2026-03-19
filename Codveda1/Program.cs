namespace Codveda1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Student s1 = new UndergraduateStudent("Roro", 22);
                Student s2 = new GraduateStudent("Ali", 25, "AI");

                s1.DisplayInfo();
                s2.DisplayInfo();
            }
            List<Student> students = new List<Student>();

            students.Add(new UndergraduateStudent("Roro", 22));
            students.Add(new GraduateStudent("Ali", 25, "AI"));

            foreach (var s in students)
            {
                s.DisplayInfo();
            }
        }
    }
}