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
            

            Console.WriteLine(v.ToString());
            Console.WriteLine(flat.ToString());
            flat.AddHabitant(v);
            flat.AddHabitant(u);
            flat.AddHabitant(i);
            flat.AddHabitant(o);
            Console.WriteLine(flat.GetInfoAboutAllHabitants());
            
        }
    }
}
