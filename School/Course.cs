using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Course
    {
        private string name;
        private List<Student> students = new List<Student>();
        public int Credits { get; set; }
        public string Name { get => name; set => name = value; }

        public Course(int credits, string name)
        {
            Credits = credits;
            Name = name;
        }

        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }
            else
            {
                Console.WriteLine("Student already added to the course");
                Console.ReadLine();
            }
        }


        StringBuilder roster = new StringBuilder();

        public void Builder()
        {
            Console.WriteLine("\nClass roster:");

            for (int i = 0; i < students.Count; i++)
            {
                roster.Append("\nStudent:" + " " + students[i] + "\n*******");
            }
        }

        public override string ToString()
        {
            Builder();
            return roster.ToString();
        }
    }
}
