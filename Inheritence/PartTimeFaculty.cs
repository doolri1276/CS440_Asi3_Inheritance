using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class PartTimeFaculty : Staff
    {

        string ssNum;

        public PartTimeFaculty(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          string department,
                          string ssNum): base(firstName, lastName, streetAddress, city, telephone,department)
        {
            this.ssNum = ssNum;
        }

        public string SsNum { get => ssNum; set => ssNum = value; }

        public override string ToString()
        {
            return base.ToString() + " ssNum : " + ssNum;
        }
    }
}
