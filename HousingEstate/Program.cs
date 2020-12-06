using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person v = new Person(50, "Zdeno", "Chara");
            Person u = new Person(12, "Jana", "Hlavata");
            Person i = new Person(45, "Peter", "Hlavaty");
            Person o = new Person(40, "Andrea", "Hlavata");

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
