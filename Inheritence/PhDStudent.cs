using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class PhDStudent : FullTimeStudent
    {
        string phdAdvisor;

        protected PhDStudent(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          int test1,
                          int test2,
                          string studentID,
                          string phdAdvisor) : base(firstName, lastName, streetAddress, city, telephone, test1, test2, studentID)
        {
            this.phdAdvisor = phdAdvisor;
        }

        public override string ComputeGrade()
        {
            return (0.3 * Test1 + 0.7* Test2).ToString();
        }

        public override string ToString()
        {
            return base.ToString() + " phdAdvisor : " + phdAdvisor;
        }

        public string PhdAdvisor { get => phdAdvisor; set => phdAdvisor = value; }
    }
}
