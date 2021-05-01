using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Road
    {
        void AssignAnimal()
        {
            Animals animals = null;
            Console.WriteLine("Choose the animal horse or donkey");
            string Choice = Console.ReadLine().ToUpper();
            switch (Choice)
            {
                case "HORSE":
                    animals = new Horse();
                    break;
                case "DONKEY":
                    animals = new Donkey();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            pullCart(animals);
        }
        void pullCart(Animals animals)
        {
            animals.Eat();
            animals.sleep();
            animals.Move();
        }
        //static void Main(string[] a)
        //{
        //    new Road().AssignAnimal();
        //    Console.ReadKey();
        //}
    }
}
