using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Student
    {

        //Student class fields
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        //Student class constructor 
        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }
        

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            NumberOfCredits += courseCredits;
            Gpa = (courseCredits * grade) / NumberOfCredits;          
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits < 24)
            {
                return "Freshmen";
            }
            else if (NumberOfCredits >= 24 || NumberOfCredits < 48)
            {
                return "Sophomore";
            }
            else if (NumberOfCredits >= 48 || NumberOfCredits <= 72)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
            
        }

    }
}
