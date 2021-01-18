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

        public  HousingEstate(int numberOfBlockOfFlat_, string street_)
        {
            NumberOfBlockOfFlat = numberOfBlockOfFlat_;
            street = street_;
        }
    }
}