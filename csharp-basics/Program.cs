using System;

namespace csharp_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class Sample 
            Car maruti = new Car();
            Console.WriteLine(maruti.color);

            Car tata = new Car();
            tata.color = "silver";
            tata.Accelerate();
            Console.WriteLine(tata.color);


            //Inheritance & Access Specifiers
            MarutiSwift JebaCar = new MarutiSwift();
            JebaCar.StartEngine();
        }
    }
}
