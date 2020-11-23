using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        private int numberOfFlat;
        private int sizeOfFlat;
        private int numberOfRooms;


        public List<Person> personList = new List<Person>() { };



        public void AddPerson(Person person)
        {
            personList.Add(person);
        }


        public Flat(int numberOfFlat, int sizeOfFlat, int numberOfRooms)
        {
            this.numberOfFlat = numberOfFlat;
            this.sizeOfFlat = sizeOfFlat;
            this.numberOfRooms = numberOfRooms;

        }

        public override string ToString()
        {
            return String.Format(
                $"Number of flat is {numberOfFlat}, size of flat is {sizeOfFlat} square meters, and number of rooms is {numberOfRooms}");
        }
    }
}
