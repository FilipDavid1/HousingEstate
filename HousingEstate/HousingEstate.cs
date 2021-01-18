using System;
using System.Collections.Generic;

namespace HousingEstate
{
    public class HousingEstate
    {
        
        public BlockOfFlats BlockOfFlats;
       
        
        private List<BlockOfFlats> _blockOfFlatsList = new List<BlockOfFlats>();

        public void AddBlockOfFlats(BlockOfFlats blockOfFlats)
        {
            _blockOfFlatsList.Add(blockOfFlats);
            blockOfFlats.currentHousingEstate = this;
        }
        
        public string GetInfoAboutAllBlockOfFlats()
        {
            string x = "";
            foreach (var blockOfFlats in _blockOfFlatsList)
            {
                x += blockOfFlats.ToString() + "\n ";
            }

            return x;
        }


        public int GetNumberOfBlockOfFlats()
        {
            return _blockOfFlatsList.Count;
        }

      /* public override string ToString()
        {
            return String.Format($"Number of block of flats is {}");
        }
        */
    }
}