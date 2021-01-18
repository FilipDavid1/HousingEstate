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
        public string GetInfoAboutAllFlats()
        {
            string x = "";
            foreach (var flat in flatList)
            {
                x += flat.ToString() + "\n ";
            }

            return x;
        }
    }
}