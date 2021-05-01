using System;
using System.Collections.Generic;
using System.Text;

namespace UndersatandingOOPS
{
    class Account
    {
        public string AccountNumber { get; set; }
        public double Blance { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public static Account operator + (Account account1,Account account2)
        {
            Account result = new Account(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            result.AccountNumber = account1.AccountNumber + account2.AccountNumber;
            result.Name = account1.Name +"and" + account2.Name;
            result.Blance = account1.Blance + account2.Blance;
            return result;
        }
        public Account(string iAccountNumber,Double iBlance,String iName)
        {
            AccountNumber = iAccountNumber;
            Blance = iBlance;
            Name = iName;
            Type = "Not sure yet";
        }
        public void OpenAccount()
        {
            Console.WriteLine("Go to the bank account number");
        }

        public void OpenAccount(string PanNumber)
        {
            Console.WriteLine("use the pan number {0}",PanNumber);
        }
        public void OpenAccount(string PanNumber, double balance)
        {
            Console.WriteLine("use the pan number {0} to open account and balance is {1}", PanNumber,balance);
        }
        public void OpenAccount(double balance,string Adhar)
        {
            Console.WriteLine("use the adhar number {0} to open account and balance is {1}", Adhar,balance);
        }
        public void PrintTheInfo()
        {
            Console.WriteLine("Account number " + AccountNumber + "\nAccount name " + Name + "\nblance " + Blance);
        }
        public override string ToString()
        {
            return "Account number " + AccountNumber + "\nAccount name " + Name + "\nblance " + Blance;
        }
        ~Account()
        {
            Console.WriteLine("Account dissolved");
        }
    }
}
