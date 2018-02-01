using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Course
    {
        private string name;
        private Dictionary<Student, int> students = new Dictionary<Student, int>();
        public int Credits { get; set; }
        public string Name { get => name; set => name = value; }

        public Course(int credits, string name)
        {
            Credits = credits;
            Name = name;
        }

        public void CreateStudent(Student key, int value)
        {
            if(students.ContainsKey(key))
            {
                students[key] = value;
            }
            else
            {
                students.Add(key, value);
            }
        }

        public void AddStudentToTheCourse(Student student)
        {
            CreateStudent(student, 0);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (KeyValuePair<Student, int> student in students)
            {
                stringBuilder.Append(string.Format("{0} - {1}\n", student.Key.Name, student.Value));
            }

            return stringBuilder.ToString();
        }
    }
}
