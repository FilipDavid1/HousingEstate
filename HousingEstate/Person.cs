using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        private int age;
        private string firstName;
        private string lastName;


        public Person(int age, string name, string lastName)
        {
            this.age = age;
            this.firstName = name;
            this.lastName = lastName;

        }


        public override string ToString()
        {
            return String.Format($"Person with name {this.firstName} last name {this.lastName} and with age {this.age}");
        }
    }
}
