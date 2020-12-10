using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Habitant v = new Habitant(50, "Zdeno", "Chara");
            Habitant u = new Habitant(12, "Jana", "Hlavata");
            Habitant i = new Habitant(45, "Peter", "Hlavaty");
            Habitant o = new Habitant(40, "Andrea", "Hlavata");

            Flat flat = new Flat(32, 60, 3);
            Flat flat2 = new Flat(23, 70, 4);

           
            

           
            Console.WriteLine(v.ToString());
            Console.WriteLine(flat.ToString());
            flat.AddHabitant(v);
            flat.AddHabitant(u);
            flat.AddHabitant(i);
            flat2.AddHabitant(o);
            Console.WriteLine(u.currentFlat.NumberOfRooms);
            Console.WriteLine(flat.GetInfoAboutAllHabitants());
            Console.WriteLine(flat.NumberOfFlats);
            Console.WriteLine(o.GetInfoAboutFlat());
            
           

        }
    }
}
