using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class UnderGradStudent : FullTimeStudent
    {
        protected UnderGradStudent(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          int test1,
                          int test2,
                          string studentID) : base(firstName, lastName, streetAddress, city, telephone, test1, test2, studentID) { }

        public override string ComputeGrade()
        {
            return gradeToLetter(0.45 * Test1 + 0.55 * Test2);
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
