using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    abstract class FullTimeStudent : Student
    {
        string studentID;

        protected FullTimeStudent(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          int test1,
                          int test2,
                          string studentID) : base(firstName, lastName, streetAddress, city, telephone, test1, test2)
        {
            this.StudentID = studentID;

        }

        public override string ToString()
        {
            return base.ToString() + " studentID : " + studentID;
        }

        public string StudentID { get => studentID; set => studentID = value; }
    }
}
