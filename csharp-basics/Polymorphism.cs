using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_basics
{
    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    public class Pig : Animal  // Derived class (child) 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
