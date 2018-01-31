using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Course
    {
        private string subject;
        readonly DateTime startDate = new DateTime(2018, 1, 28);
        private List<string> listOfStudents;

        public string Subject { get => subject; set => subject = value; }
        public DateTime StartDate => startDate;
        public List<string> ListOfStudents { get => listOfStudents; set => listOfStudents = value; }
    }
}
