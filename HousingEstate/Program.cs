using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person n = new Person(12, "Zdenek", "Polreich");
            Console.WriteLine(n.ToString());
        }
    }
}
