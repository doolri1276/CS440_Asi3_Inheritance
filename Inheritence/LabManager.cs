using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class LabManager : Employee
    {

        public LabManager(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          string department,
                          string empID) : base(firstName, lastName, streetAddress, city, telephone, department, empID)
        {   
        }

        public override string ToString()
        {
            return base.ToString() + " labManager";
        }
    }
}
