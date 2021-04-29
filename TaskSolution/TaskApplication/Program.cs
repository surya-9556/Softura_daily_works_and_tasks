using System;

namespace TaskApplication
{
    class Program
    {
        //1
        static void EvenNumber()
        {
            int num = Int32.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number" + num);
            }
        }
        //2
        static void DivisibleBySeven()
        {
            int flag = 0, sum = 0;
            while (flag >= 0)
            {
                Console.WriteLine("Enter the number:");
                flag = Int32.Parse(Console.ReadLine());
                if(flag%7 == 0)
                {
                    sum = sum + flag;
                    Console.WriteLine(sum);
                }
            }
        }
        //3
        static void MinAndMax()
        {
            Console.WriteLine("Enter the Number1:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number2:");
            int num2 = Int32.Parse(Console.ReadLine());
            for (int i = num1; i < num2; i++)
            {
                int count = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if(i%j == 0)
                    {
                        count += 1;
                        break;
                    }
                }
                if(count == 0 & i != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //4
        static void UserAndPassword()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the user name:");
                string Username = Console.ReadLine();
                Console.WriteLine("Enter the password:");
                string password = Console.ReadLine();
                if (Username == "Ramu" && password == "1234")
                {
                    Console.WriteLine("Welcome");
                    break; 
                }
                else
                {
                    Console.WriteLine("Login failed try again!!!!");
                    count += 1;
                }
            }
            if(count >= 3)
            {
                Console.WriteLine("Account closed");
            }
            else
            {
                Console.WriteLine("Loged in successfully");
            }
        }
        //5
        static void UserInfo()
        {
            Console.WriteLine("Enter the number1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            string operato = Console.ReadLine();
            if(operato == "+")
            {
                int Sum = number1 + number2;
                Console.WriteLine("Sum is:" + Sum);
            }
            else if (operato == "-")
            {
                int difference = number1 - number2;
                Console.WriteLine("difference is:" + difference);
            }
            else if (operato == "*")
            {
                int Mul = number1 * number2;
                Console.WriteLine("Multiplication is:" + Mul);
            }
            else if (operato == "/")
            {
                int div = number1 / number2;
                Console.WriteLine("Division is:" + div);
            }
            else
            {
                Console.WriteLine("Enter a valid Operator");
            }
        }
        static void Main(string[] args)
        {
            UserInfo();
            MinAndMax();
            EvenNumber();
            UserAndPassword();
            DivisibleBySeven();
        }
    }
}
