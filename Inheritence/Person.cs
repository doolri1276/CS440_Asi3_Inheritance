using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    abstract class Person
    {
        string firstName;
        string lastName;
        string streetAddress;
        string city;
        string telephone;

        protected Person(string firstName, string lastName, string streetAddress, string city, string telephone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.streetAddress = streetAddress;
            this.city = city;
            this.telephone = telephone;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string City { get => city; set => city = value; }
        public string Telephone { get => telephone; set => telephone = value; }



        public override string ToString()
        {
            return "firstName : "+firstName + " lastName : " + lastName + " streetAddress : " + streetAddress + " city : " + city + " telephone : " + telephone;
        }

    }
}
