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


       


        public Person(int age_, string name, string lastName)
        {
            age = age_;
            firstName = name;
            surName = lastName;

        }


        public override string ToString()
        {
            return $"Person with name {firstName} last name {surName} and with age {age}";
        } 
        
        public Person()
        {

        }
        
        
    }
}
