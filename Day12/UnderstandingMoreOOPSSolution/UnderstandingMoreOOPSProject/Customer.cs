using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public void TakeCustomersDate()
        {
            Console.WriteLine("Please enter the Id");
            int id = 0;
            while(!Int32.TryParse(Console.ReadLine(),out id))
            {
                Console.WriteLine("Invalied Entry. please try again");
            }
            Id = id;
            Console.WriteLine("Plese enter the customer name");
            name = Console.ReadLine();
            Console.WriteLine("Plese enter the customer phone number");
            phone = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Id: " + Id + "Name " + name + "Phone no " + phone;
        }
    }
}