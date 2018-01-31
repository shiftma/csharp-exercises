using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    public class Student
    {
        string name;
        int studentId;
        int numberOfCredits = 0;
        double gpa = 0;

        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }

    }
}
