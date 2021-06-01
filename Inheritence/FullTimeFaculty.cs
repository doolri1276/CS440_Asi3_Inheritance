using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class FullTimeFaculty : Employee
    {
        public enum Rank
        {
           ASSISTANT , ASSOCIATE, FULLPROFESSOR
        }

        Rank facultyRank;

        private Rank FacultyRank { get => facultyRank; set => facultyRank = value; }

        public FullTimeFaculty(string firstName,
                          string lastName,
                          string streetAddress,
                          string city,
                          string telephone,
                          string department,
                          string empID,
                          Rank rank) : base(firstName, lastName, streetAddress, city, telephone, department, empID)
        {
            this.FacultyRank = rank;
        }

        public override string ToString()
        {
            return base.ToString() + " rank : " + facultyRank;
        }
    }
}
