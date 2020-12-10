using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HousingEstate
{
    public class Flat
    {
        private int numberOfFlat;
        private int sizeOfFlat;
        private int numberOfRooms;




        public int NumberOfFlats
        {
            get => numberOfFlat;

            set => numberOfFlat = value;
        }


        public int SizeOfFlat
        {
            get => sizeOfFlat;

            set => sizeOfFlat = value;
        }

        public int NumberOfRooms
        {
            get => numberOfRooms;

            set => numberOfRooms = value;
        }

       

        public List<Person> habitantList = new List<Person>() { };

        public Flat(int numberOfFlat, int sizeOfFlat, int numberOfRooms)
        {
            this.numberOfFlat = numberOfFlat;
            this.sizeOfFlat = sizeOfFlat;
            this.numberOfRooms = numberOfRooms;

        }

        public override string ToString()
        {
            return String.Format($"Number of flat is {numberOfFlat}, size of flat is {sizeOfFlat} square meters, and number of rooms is {numberOfRooms}");
        }

        public void AddHabitant(Habitant habitant)
        {
            habitantList.Add(habitant);
            habitant.currentFlat = this;
            

        }



        public string GetInfoAboutAllHabitants()
        {
            string neviem ="";
            foreach (var habitant in habitantList)
            {
                neviem += habitant.ToString() + "\n ";
                
            }
            return neviem;
        }



    }
}
