using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
   public class Habitant : Person 
    {
        
        public Flat currentFlat;

      

        public Habitant(int age, string name, string lastName) : base(age, name, lastName) { }

        public string GetInfoAboutFlat()
        {
            return this.currentFlat.ToString();
        }
    

    
    }
}
