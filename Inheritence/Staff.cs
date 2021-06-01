using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    abstract class Staff : Person
    {
        string department;

        public string Department { get => department; set => department = value; }

        public Staff(string firstName, 
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone, 
                          string department) : base(firstName, lastName, streetAddress, city, telephone)
        {
            this.department = department;
            
        }

        public override string ToString()
        {
            return base.ToString() + " department : " + department;
        }
    }
}
