using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsProject
{
    class Program
    {
        //For Array list it will not provide any error because it will take all data types.
        //ArrayList numbers = new ArrayList();
        //It will take only the type of data type that we have given as the input.
        //List<int> numbers = new List<int>();
        /// <summary>
        /// Taking numbers from user until user enters a negative numbers.
        /// </summary>
        /// <param name="args"></param>
        List<int> TakeNumbersFromUser()
        {
            List<int> numbers = new List<int>();
            int number = 0;
            do
            {
                Console.WriteLine("Please enter a number. Enter a negative number to quite(Example -1)");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    int result = 10 / number;
                    if (number >= 0)
                    {
                        numbers.Add(number);
                    }
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("User needs to enter whole number only");
                    Console.WriteLine(formatException.Message);
                }
                catch (DivideByZeroException dbz)
                {
                    Console.WriteLine("The input cannot be divisible by zero");
                }
                catch (OverflowException overFlowException)
                {
                    Console.WriteLine("The number is too big");
                }
            } while (number >= 0);
            Console.WriteLine("The number of numbers entered "+numbers.Count);
            //numbers.Add(100);
            //numbers.Add("Surya");
            //numbers.Add(12.4f);
            //numbers.Add(123.4);
            if (numbers.Count == 0)
                return null;
            //numbers = null;
            else
                return numbers;
        }

        void SortGivenNumbers()
        {
            List<int> MyNumbers = TakeNumbersFromUser();
            try
            {
                if (MyNumbers != null)
                {
                    MyNumbers.Sort();
                    PrintAllTheNumbers(MyNumbers);
                }
                else
                {
                    Console.WriteLine("There are no values in the list");
                }
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("There are no numbers to be printed");
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot sort. Sorry");
            }
        }

        private void PrintAllTheNumbers(List<int> myNumbers)
        {
            if(myNumbers.Count > 0)
            {
                foreach (var item in myNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("There are no elements in the list to sort");
            }
        }

        //static void Main(string[] args)
        //{
        //    Program program = new Program();
        //    program.TakeNumbersFromUser();
        //    program.SortGivenNumbers();
        //    //Console.WriteLine("Hello World!");
        //}
    }
}
