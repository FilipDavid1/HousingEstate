namespace HousingEstate
{
    public class Entrance
    {
        private int numberOfEntrance;
        private int numberOfFloors;
        private int numberOfFlats;

        public int NumberOfEntrance
        {
            get => numberOfEntrance;
            set
            {
                numberOfEntrance = value < 0 ? 0 : value;
            }
        }

        public int NumberOfFlats
        {
            get => numberOfFlats;
            set
            {
                numberOfFlats   = value < 0 ? 0 : value;
            } 
        }

        public int NumberOfFloors
        {
            get => numberOfFloors;
            set
            {
                numberOfFloors = value < 0 ? 0 : value;
            }
        }

        public Entrance(int numberOfEntrance, int numberOfFloors, int numberOfFlats)
        {
            this.numberOfEntrance = numberOfEntrance;
            this.numberOfFloors = numberOfFloors;
            this.numberOfFlats = numberOfFlats;
        }
    }
}