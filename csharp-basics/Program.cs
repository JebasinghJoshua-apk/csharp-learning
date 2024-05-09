using System;
using System.Diagnostics.Contracts;
using System.IO;
using static System.Net.WebRequestMethods;

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

            //Interfaces
            //Class or abstract class - Inhertiance
            //Interface - Implementation
            //An interface defines a contract.
            //Any class , record or struct that implements that contract must provide an implementation of the
            //members defined in the interface. An interface may define a default implementation for members.
            Console.WriteLine("----------------------------------");
            IFish tunaFish = new TunaFish();

            tunaFish.Swim();

            Console.WriteLine("----------------------------------");


            //Enum
            var currentWorkingPart = CarParts.Engine;

            Console.WriteLine("----------------------------------");

            var text = System.IO.File.ReadAllText("C:\\Users\\jebas\\OneDrive\\Desktop\\sample\\File.txt");
            Console.WriteLine(text);


            using (StreamWriter sw = System.IO.File.AppendText("C:\\Users\\jebas\\OneDrive\\Desktop\\sample\\File.txt"))
            {
                sw.WriteLine("Gfg");
                sw.WriteLine("GFG");
                sw.WriteLine("GeeksforGeeks");
            }
        }
    }
}
