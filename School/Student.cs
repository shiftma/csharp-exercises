using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Student
    {

        //Student class fields
        private static int nextStudentId = 1;
        double totalQualityScore;

        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa {
            get { return totalQualityScore / NumberOfCredits; }
            private set { totalQualityScore = value; }
        }

        //Student class constructor 
        public Student(string name, int studentId,
            int numberOfCredits, float gpa)
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
            Name = name;
            nextStudentId++;
        }

        // course credit between (2-5), grade between (0-4)
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            NumberOfCredits += courseCredits;
            totalQualityScore = totalQualityScore + (courseCredits * grade);

        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits < 30)
            {
                return "Freshmen";
            }
            else if (NumberOfCredits >= 30 || NumberOfCredits < 60)
            {
                return "Sophomore";
            }
            else if (NumberOfCredits >= 60 || NumberOfCredits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }

        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            Student studentObj = obj as Student;
            return (studentObj.StudentId == StudentId);

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return StudentId;
        }

        public override string ToString()
        {
            return Name + "\nID: "
                    + StudentId + "\nGPA: "
                    + Gpa + "\nCredits: "
                    + NumberOfCredits + "\n"
                    + GetGradeLevel() + "\n";
        }

    }
}
