using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    abstract class Student : Person
    {
        int test1;
        int test2;

        protected Student(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          int test1,
                          int test2) :base(firstName, lastName, streetAddress, city, telephone)
        {
            this.test1 = test1;
            this.test2 = test2;
        }

        public int Test1 { get => test1; set => test1 = value; }
        public int Test2 { get => test2; set => test2 = value; }

        public override string ToString()
        {
            return base.ToString()+" test1 : "+test1+" test2 : "+test2;
        }

        public abstract string ComputeGrade();
    }
}
