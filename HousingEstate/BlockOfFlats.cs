using System;
using System.Collections.Generic;

namespace HousingEstate
{
    public class BlockOfFlats
    {
        private int numberOfBlockOfFlat;
        private string street;
        public HousingEstate currentHousingEstate;

        public int NumberOfBlockOfFlat
        {
            get => numberOfBlockOfFlat;
            set
            {
                numberOfBlockOfFlat = value < 0 ? 0 : value;
            }
        }

        public string Street
        {
            get => street;
            set => street = value;
        }

        public List<Flat> flatList = new List<Flat>();
        public List<Entrance> entranceList = new List<Entrance>();

        public  BlockOfFlats(int numberOfBlockOfFlat, string street)
        {
            this.NumberOfBlockOfFlat = numberOfBlockOfFlat;
            this.street = street;
        }


        public string GetInfoAboutAllEntrances()
        {
            string x = "";
            foreach (var entrances in entranceList)
            {
                x += entrances.ToString() + "\n ";
            }

            return x;
        }

        public override string ToString()
        {
            return String.Format($"Number os block is {numberOfBlockOfFlat} and name of street is {street}. ");
        }

        public void AddEntrance(Entrance entrance)
        {
            entranceList.Add(entrance);
            entrance.currentBlockOfFlats = this;
        }
        public void AddFlat( Flat flat)
        {
            flatList.Add(flat);
            flat.currentBlockOfFlats = this;
        }
        public string GetInfoAboutAllFlats()
        {
            string x = "";
            foreach (var flats in flatList)
            {
                x += flats.ToString() + "\n ";
            }

            return x;
        }

        public string GetInfoAboutHousingEstate()
        {
            return this.currentHousingEstate.ToString();
        }
        
    }
}