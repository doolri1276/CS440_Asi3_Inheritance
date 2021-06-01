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

        protected string gradeToLetter(double avg)
        {
            string grade = "";
            if (avg >= 93)
                grade = "A";
            else if (avg >= 90)
                grade = "A-";
            else if (avg >= 87)
                grade = "B+";
            else if (avg >= 83)
                grade = "B";
            else if (avg >= 80)
                grade = "B-";
            else if (avg >= 77)
                grade = "C+";
            else if (avg >= 73)
                grade = "C";
            else if (avg >= 70)
                grade = "C-";
            else if (avg >= 67)
                grade = "D+";
            else if (avg >= 63)
                grade = "D";
            else if (avg >= 60)
                grade = "D-";
            else
                grade = "F";

            return grade;


        }
    }
}
