using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person v = new Person(50, "Zdeno", "Chara");
            
            Flat flat = new Flat(32, 60, 3);
            

            Console.WriteLine(v.ToString());
            Console.WriteLine(flat.ToString());
        }
    }
}
