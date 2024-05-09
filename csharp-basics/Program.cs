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

            //Constructor
            //Default Constructor
            //Parameterized Constructor
            School school = new School();
            Console.WriteLine(school.SchoolName);

            //Properties
            var company = new Company();
            company.CompanyName = "Microsoft";
            Console.WriteLine(company.CompanyName);

            //Polymorphism & Overide
            Console.WriteLine("----------------------------------");
            Animal pig = new Pig();
            pig.AnimalSound();

            Animal dog = new Dog();
            dog.AnimalSound();
            Console.WriteLine("----------------------------------");

            //Abstract Classes and methods
            //Abstract class: is a restricted class that cannot be used to create objects(to access it, it must be inherited from another class).
            //Abstract method: can only be used in an abstract class, and it does not have a body.The body is provided by the derived class (inherited from).
            //An abstract class can have both abstract and regular methods:
            Console.WriteLine("----------------------------------");
            
            Duck duck = new Duck();
            duck.Sleep();
            duck.BirdSound();

            Sparrow sparrow = new Sparrow();
            sparrow.Sleep();
            sparrow.BirdSound();

            Console.WriteLine("----------------------------------");
        } 
    }
}
