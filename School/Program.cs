using System;

namespace School
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back to School!");

            Student josh = new Student("Josh");
            Student matt = new Student("Matt");

            josh.AddGrade(3, 4);
            matt.AddGrade(3, 3);
            matt.AddGrade(4, 3);

            Course csharp = new Course(4, "csharp");
            Course python = new Course(3, "python");

            csharp.AddStudentToTheCourse(josh);
            python.AddStudentToTheCourse(matt);
            csharp.CreateStudent(josh, 75);

            Console.WriteLine(josh);
            Console.WriteLine();

            Console.WriteLine(csharp.Name);
            Console.WriteLine(csharp.ToString());
           

            Console.ReadLine();

            //static void WriteResult(string name, double gpa)
            //{
            //    Console.WriteLine($"{name}: {gpa}", name, gpa);
            //    Console.ReadLine();
            //}

            //static void WriteResult(DateTime dateTime)
            //{
            //    Console.WriteLine(dateTime);
            //    Console.ReadLine();
            //}
        }
    }
}