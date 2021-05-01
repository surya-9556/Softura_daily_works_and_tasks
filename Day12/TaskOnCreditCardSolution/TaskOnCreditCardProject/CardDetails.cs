using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOnCreditCardProject
{
    class CardDetails
    {
        public int CardNumber { get; set; }
        public string Date { get; set; }
        public int CVV { get; set; }
        public void CheckCard()
        {
            Console.WriteLine("Please enter the Card Number");
            CardNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese enter the Date");
            Date = Console.ReadLine();
            Console.WriteLine("Plese enter CVV");
            int id = 0;
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalied Entry. please try again");
            }
        }

        public override string ToString()
        {
            return "Card Number " + CardNumber + "\nExpire Date " + Date + "\nCVV" + CVV;
        }
    }
}
