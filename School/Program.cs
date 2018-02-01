using System;

namespace School
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back to School!");
            Console.WriteLine();

            Student josh = new Student("Josh");
            Student matt = new Student("Matt");
            Student zak = new Student("Zak");

            Course csharp = new Course(4, "csharp");
            Course python = new Course(3, "python");

            csharp.AddStudent(josh);
            python.AddStudent(matt);
            python.AddStudent(zak);
            python.AddStudent(zak);

            josh.AddGrade(4, 4);
            josh.AddGrade(3, 4);
            matt.AddGrade(3, 3);
            zak.AddGrade(3, 4);

            Console.WriteLine(josh);
            Console.WriteLine();

            Console.WriteLine(matt);
            Console.WriteLine();

            Console.WriteLine(zak);
            Console.WriteLine();

            Console.WriteLine(python.ToString());

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