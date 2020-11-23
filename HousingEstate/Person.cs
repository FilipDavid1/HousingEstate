using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        private int age;
        private string name;
        private string lastName;


        public Person(int age, string name, string lastName)
        {
            this.age = age;
            this.name = name;
            this.lastName = lastName;

        }


        public override string ToString()
        {
            return String.Format($"Person with name {this.name} last name {this.lastName} and with age {this.age}");
        }
    }
}
