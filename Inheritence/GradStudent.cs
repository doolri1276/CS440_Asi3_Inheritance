using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class GradStudent : FullTimeStudent
    {
        string thesis;
        protected GradStudent(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          int test1,
                          int test2,
                          string studentID,
                          string thesis) : base(firstName, lastName, streetAddress, city, telephone, test1, test2, studentID) 
        {
            this.thesis = thesis;
        }

        public string Thesis { get => thesis; set => thesis = value; }

        public override string ComputeGrade()
        {
            return gradeToLetter(0.45 * Test1 + 0.55 * Test2);
        }

        public override string ToString()
        {
            return base.ToString() + " thesis : " + thesis;
        }
    }
}
