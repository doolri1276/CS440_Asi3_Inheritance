using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class PartTimeStudent : Student
    {
        string ssNum;

        protected PartTimeStudent(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          int test1,
                          int test2,
                          string ssNum) : base(firstName, lastName, streetAddress, city, telephone, test1, test2)
        {
            this.SsNum = ssNum;
        
        }

        public string SsNum { get => ssNum; set => ssNum = value; }

        public override string ComputeGrade()
        {
            return (0.3 * Test1 + 0.7 * Test2).ToString();
        }

        public override string ToString()
        {
            return base.ToString() + " ssNum : " + ssNum;
        }
    }
}
