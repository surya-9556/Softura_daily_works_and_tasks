using System;

namespace CreditCardProject
{
    class Program
    {
        public void CreditCard()
        {
            Console.WriteLine("Enter the credit card number");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter the Year on the card");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month on the card");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Day on the card");
            int Day = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(Year, Month, Day);

            Console.WriteLine("Enter the CVV on credit card");
            string num2 = Console.ReadLine();

            string RevrerseString = string.Empty;
            for (int i = num1.Length - 1; i >=0 ; i--)
            {
                RevrerseString += num1[i];
            }

            Console.WriteLine(RevrerseString);

            int num;
            int num3;
            int sum = 0;
            int num4 = 0;
            int num5 = 0;
            for (int i = 0; i < RevrerseString.Length; i++)
            {
                char v = RevrerseString[i];
                num = (int)Char.GetNumericValue(v);
                if (i%2 == 0)
                {
                    num3 = num * 2;
                    num5 += num3;
                }

                else
                {
                    num4 += num;
                }
                sum = num5 + num4;
            }

            //int CardNumber;
            int value = dt.CompareTo(DateTime.Today);

            if ((num1.Length == 16 || num1.Length == 15) && (value > 0) && (num2.Length == 3) && (sum % 10 == 0))
            {
                Console.WriteLine("Valied Credit card");
            }
            else if ((num1.Length != 16 & num1.Length > 16)|| (num1.Length != 15 & num1.Length < 15))
            {
                Console.WriteLine("Invalied Card Number");
            }
            else if (num2.Length != 3)
            {
                Console.WriteLine("Invalied CVV Number");
            }
            else if (value < 0)
            {
                Console.WriteLine("Expired already");
            }
            else if(sum%10 != 0)
            {
                Console.WriteLine("Credit card number is logically incorrect");
            }
            else
            {
                Console.WriteLine("Invalied Credit Card details");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CreditCard();
            Console.ReadKey();
        }
    }
}
