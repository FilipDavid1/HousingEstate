using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    public class Person
    {
        protected int age;
        protected string firstName;
        protected string surName;
       

        public int Age
        {
            get => age;

            set
            {
                age = value < 0 ? 0 : value;
                
            }
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
        
        public Person()
        {

        }
        
        
    }
}
