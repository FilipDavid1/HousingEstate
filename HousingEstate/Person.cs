using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        private int age;
        private string firstName;
        private string surName;
        public Flat currentFlat;

        public int Age
        {
            get => age;

            set => age = value;
        }

        public string FirstName
        {
            get => firstName;

            set => firstName = value;
        }

        public string Surname
        {
            get => surName;
            set => surName = value;
        }


       public string GetInfoAboutFlat()
       {
           return this.currentFlat.ToString();
       }


        public Person(int age, string name, string lastName)
        {
            this.age = age;
            this.firstName = name;
            this.surName = lastName;

        }


        public override string ToString()
        {
            return String.Format($"Person with name {this.firstName} last name {this.surName} and with age {this.age}");
        }
    }
}
