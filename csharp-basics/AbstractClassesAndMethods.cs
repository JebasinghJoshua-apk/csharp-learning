using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_basics
{
    public abstract class Bird
    {
        public abstract void BirdSound();

        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    public class Duck : Bird
    {
        public override void BirdSound()
        {
            Console.WriteLine("Kuak kuak");
        }
    }

    public class Sparrow : Bird
    {
        public override void BirdSound()
        {
            Console.WriteLine("koo koo");
        }
    }
}
