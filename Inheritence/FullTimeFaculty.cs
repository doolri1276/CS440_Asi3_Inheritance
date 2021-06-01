using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class FullTimeFaculty : Employee
    {
        public enum Level
        {
            Assistant, Associate, FullProfessor
        }

        Level rank;

        private Level Rank { get => rank; set => rank = value; }

        public FullTimeFaculty(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          string department,
                          string empID,
                          Level rank) : base(firstName, lastName, streetAddress, city, telephone, department, empID)
        {
            this.Rank = rank;
        }

        public override string ToString()
        {
            return base.ToString() + " rank : " + rank;
        }
    }
}
