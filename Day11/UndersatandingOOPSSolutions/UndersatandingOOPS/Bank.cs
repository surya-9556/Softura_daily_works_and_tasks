using System;
using System.Collections.Generic;
using System.Text;

namespace UndersatandingOOPS
{
    class Bank
    {
        void UnderStandingOperatorOverloading()
        {
            Account account1 = new Account(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            //Account account2 = new Account(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            //Account account3 = account1 + account2;
            //Console.WriteLine("Operator");
            //account1.PrintTheInfo();
            //account2.PrintTheInfo();
            //Console.WriteLine("---------------");
            //account3.PrintTheInfo();
            Console.WriteLine(account1);
        }
        void CheckAndCheck()
        {
            //Account account = new Account(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            //account = null;
        }
        static void Main(string[] args)
        {
            //Account account = new Account(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            //account.OpenAccount();
            //account.OpenAccount("EOMP8097D");
            //account.OpenAccount("EOMP8097D", 9000);
            //account.OpenAccount(9000, "6211-5176-3689");
            //account.PrintTheInfo();
            //GC.Collect()
            Bank bank = new Bank();
            bank.UnderStandingOperatorOverloading();
        }
    }
}
