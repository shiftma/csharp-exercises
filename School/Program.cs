using System;

namespace School
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back to School!");

            Student josh = new Student("Josh", 32, 14, 3.5f);
            WriteResult(josh.Name, josh.Gpa);
            Console.WriteLine(josh.GetGradeLevel());
            Console.ReadLine();

            Student mike = new Student("Mike", 32, 8, 3.2f);
            WriteResult(mike.Name, mike.Gpa);
            Console.WriteLine(mike.GetGradeLevel());
            Console.ReadLine();
            mike.AddGrade(5, 4);
            WriteResult(mike.Name, mike.Gpa);

            Course newCourse = new Course();
            newCourse.Subject = "Math";
            WriteResult(newCourse.StartDate);

        }

        static void WriteResult(string name, double gpa)
        {
            Console.WriteLine($"{name}: {gpa}", name, gpa);
            Console.ReadLine();
        }

        static void WriteResult(DateTime dateTime)
        {
            Console.WriteLine(dateTime);
            Console.ReadLine();
        }
    }
}
