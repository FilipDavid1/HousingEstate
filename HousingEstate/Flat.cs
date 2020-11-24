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


        public List<Person> habitantList = new List<Person>() { };

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

        public void AddHabitant(Person habitant)
        {
            habitantList.Add(habitant);

        }



        public string GetInfoAboutAllHabitants()
        {
            string neviem ="";
            foreach (var habitant in habitantList)
            {
                neviem += habitant.ToString() + "\n";
                
            }
            return neviem;
        }



    }
}
