using System.Collections.Generic;

namespace HousingEstate
{
    public class BlockOfFlats
    {
        private int numberOfBlockOfFlat;
        private string street;

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

        public  HousingEstate(int numberOfBlockOfFlat, string street)
        {
            this.NumberOfBlockOfFlat = numberOfBlockOfFlat;
            this.street = street;
        }
    }
}