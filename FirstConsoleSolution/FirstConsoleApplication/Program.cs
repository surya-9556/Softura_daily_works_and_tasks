using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static int num1, num2;//class level scope
        static void TakeTwoNumbers()
        {
            num1 = Convert.ToInt32(Console.ReadLine()); //unboxing - converting the ref type to value type
            num2 = Int32.Parse(Console.ReadLine());
        }
        static void FirstMethod()
        {
            //Console.WriteLine("Hello From My Method");
            //Console.WriteLine("code snippet");
            Console.WriteLine("Please enter the data");
            String data = Console.ReadLine();
            Console.WriteLine("Entered data " +data);
        }
        static void DealingWithInteger()
        {
            Console.WriteLine("Enter The Numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int c = number1 + number2;
            int d = number1 - number2;
            int e = number1 * number2;
            double f = number1 / number2;
            Console.WriteLine("Sum value is "+c);
            Console.WriteLine("Substraction value is "+d);
            Console.WriteLine("Multipied value is "+e);
            Console.WriteLine("Divided value is "+f);
        }
        static void Calculation()
        {
            TakeTwoNumbers();
            int c = num1 + num2;
            Console.WriteLine("Sum is {0} and {1} is {2}",num1,num2,c);
            float fnum1, fnum2;
            fnum1 = num1;
            fnum2 = num2;
            float f = (float)(fnum1 / fnum2);
            Console.WriteLine("division is {0} and {1} is {2}", num1, num2, f);
        }
        static void BiggestOfTwoNumbers()
        {
            TakeTwoNumbers();
            if (num1 == num2)
            {
                Console.WriteLine("num1 {0} and num2 {1} are equal");
            }
            else if (num1 > num2) {
                Console.WriteLine("num1 {0} is greater");
            }
            else
            {
                Console.WriteLine("num2 {1} are lesser");
            }
        }

        static void BiggestOfThreeNumbers()
        {
            TakeTwoNumbers();
            int num3 = Int32.Parse(Console.ReadLine());
            if (num1 == num2 & num2 == num3 & num1 == num3)
            {
                Console.WriteLine("num1 {0} and num2 {1} are equal");
            }
            else if (num1 > num2 & num1 >num3)
            {
                Console.WriteLine("num1 {0} is greater");
            }
            else if (num2 > num3 & num2 > num3)
            {
                Console.WriteLine("num2 {1} are greater");
            }
            else
            {
                Console.WriteLine("num2 {2} are greater");
            }
        }
        static void PrintDayOfWeek()
        {
            Console.WriteLine("Please enter the line");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                case "Teausday":
                case "Wensday":
                case "Thursday":
                    Console.WriteLine("Weekday");
                    break;
                case "Friday":
                    Console.WriteLine("Weekday but will be Weekend soon");
                    break;
                case "saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Enter a valid day");
                    break;
            }
        }

        static void Iterations()
        {
            //for loop

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("For loop Ends");

            //while loop

            //int flag = 0,sum = 0;
            //while (flag >= 0)
            //{
            //    sum += flag;
            //    flag = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Here We Go.... The sum is " + sum);

            //do while loop

            int flag = -1, sum = 0;
            do
            {
                flag = Convert.ToInt32(Console.ReadLine());
                sum += flag;
            } while (flag >= 0);
            Console.WriteLine("Here We Go.... The sum is " + sum);
        }

        static void ErrorHandling()
        {
            int num = 0;
            Console.WriteLine("Please enter the value");
            //num = Int32.Parse(Console.ReadLine());
            while (Int32.TryParse(Console.ReadLine(), out num) == false)
                Console.WriteLine("Invalied integer. Please enter the correct one");
            Console.WriteLine("The number is "+num);
        }

        static void Main(string[] args)
        {
            //DealingWithInteger();
            //FirstMethod();
            //Console.WriteLine("Hello World!");
            //Calculation();
            //BiggestOfTwoNumbers();
            //PrintDayOfWeek();
            //Iterations();
            //BiggestOfThreeNumbers();
            ErrorHandling();
        }
    }
}