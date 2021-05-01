using System;
using System.Collections.Generic;
using System.Text;

namespace UndersatandingOOPS
{
    class Computer : Calculator //derived class/sub class/child cllass
    {
        public Computer()
        {
            Make = "IBM";
            Speed = 1001;
        }
        public override void DoWork()//dynamic polymorphism - overriding
        {
            base.DoWork();
            //Console.WriteLine("Calculating.....");
            Console.WriteLine("Done Work");
        }
    }
    class Calculator //base class/super class/parent class
    {
        public string Make { get; set; }
        public int Speed { get; set; }
        public Calculator()
        {
            Make = "ABC corp.";
            Speed = 101;
        }
        public void PrintCalculator()
        {
            Console.WriteLine("Make " + Make);
            Console.WriteLine("Speed " + Speed);
        }

        //public void Calculate()
        //{
        //    Console.WriteLine("Calculating.....");
        //}

        public virtual void DoWork()
        {
            Console.WriteLine("Done Work");
        }
    }
}

C: \Users\Lenovo\source\repos\UndersatandingOOPSSolutions\UndersatandingOOPS\Calculator.cs
