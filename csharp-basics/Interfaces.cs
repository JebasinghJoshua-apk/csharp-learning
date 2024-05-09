using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_basics
{
    public class Mammal
    {

    }
    public interface IFish
    {
        public void Swim();
        public void Eat();
    }

    public class TunaFish : Mammal, IFish
    {
        public void Eat()
        {
            Console.WriteLine("eat other fish");
        }

        public void Swim()
        {
            Console.WriteLine("Tuna will swim");
        }
    }
}
