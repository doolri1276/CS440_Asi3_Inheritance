using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    abstract class Employee : Staff
    {
        string empID;

        public Employee(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          string department,
                          string empID) : base(firstName, lastName, streetAddress, city, telephone, department)
        {
            this.empID = empID;

        }

        public override string ToString()
        {
            return base.ToString() + " empID : " + empID;
        }
        public string EmpID { get => empID; set => empID = value; }
    }
}
