using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class UndersatandinArray
    {
        void SingleDimenssionArray()
        {
            int[] intArray = new int[5];
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Please enter the numbers");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have entered 5 elements");
            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }

        }
        void UnderstandingMultiDimArray()
        {
            string[,] strArr = new string[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Console.Write(i * j + " ");
                    strArr[i, j] = Console.ReadLine();
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(strArr[i,j]," ");
                }
                Console.WriteLine();
            }
        }

        //void UnderstandingJaggedArray()
        //{
        //    int[][] intArr = new int[3][];
        //    for (int i = 0; i < intArr.Length; i++)
        //    {
        //        Console.WriteLine("Enter The numbre of rows" + i);
        //        int size = Convert.ToInt32(Console.ReadLine());
        //        intArr[i] = new intArr[size];
        //    }
        //    for (int i = 0; i < 2; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(intArr[i, j], " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //static void Main(string[] a)
        //{
        //    new UndersatandinArray().UnderstandingJaggedArray();
        //    Console.ReadKey();
        //}
    }
}
