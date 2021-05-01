using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOnCreditCardProject
{
    class Card
    {
        CardDetails[] CardDetails;
        public Card(int size)
        {
            CardDetails = new CardDetails[size];
        }
        public void readCardDetails()
        {
            for (int i = 0; i < CardDetails.Length; i++)
            {
                CardDetails[i] = new CardDetails();
                CardDetails[i].CheckCard();
            }
        }
        public void PrintAll()
        {
            foreach (CardDetails CardDetails in CardDetails)
            {
                Console.WriteLine(CardDetails);
            }
        }
        //static void Main(string[] args)
        //{
        //    Card card= new Card(3);
        //    card.readCardDetails();
        //    card.PrintAll();
        //    Console.ReadKey();
        //}
    }
}
