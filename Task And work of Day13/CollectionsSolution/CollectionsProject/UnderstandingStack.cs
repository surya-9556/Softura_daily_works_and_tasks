using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class UnderstandingStack
    {
        Stack<string> myStack;
        Queue<string> myQueue;
        public UnderstandingStack()
        {
            myStack = new Stack<string>();
            myQueue = new Queue<string>();
        }

        void AddItemsToStack()
        {
            myStack.Push("blue");
            myStack.Push("red");
            myStack.Push("yellow");
        }

        void AddItemsToQueue()
        {
            myQueue.Enqueue("blue");
            myQueue.Enqueue("red");
            myQueue.Enqueue("yellow");
        }

        void PrintElementsOfStack()
        {
            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(myStack.Count);

            while(myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.WriteLine(myStack.Count);
        }

        void PrintElementsOfQueue()
        {
            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(myStack.Count);

            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine(myQueue.Count);
        }
        //static void Main(string[] args)
        //{
        //    UnderstandingStack understanding = new UnderstandingStack();
        //    //understanding.AddItemsToStack();
        //    //understanding.PrintElementsOfStack();

        //    understanding.AddItemsToQueue();
        //    understanding.PrintElementsOfQueue();
        //}
    }
}
