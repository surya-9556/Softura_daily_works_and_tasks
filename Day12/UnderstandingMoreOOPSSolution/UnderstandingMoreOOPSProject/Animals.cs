using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    abstract class Animals
    {
        public void Eat()
        {
            Console.WriteLine("Eat eat. Much much.");
        }
        public void sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZ");
        }
        public abstract void Move();
    }
}
