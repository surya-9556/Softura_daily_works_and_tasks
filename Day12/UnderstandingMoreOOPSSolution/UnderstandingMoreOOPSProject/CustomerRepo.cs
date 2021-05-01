using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class CustomerRepo
    {
        Customer[] customers;
        public CustomerRepo()
        {

        }
        public CustomerRepo(int size)
        {
            customers = new Customer[size];
        }
        public void readCustomerData()
        {
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new Customer();
                customers[i].TakeCustomersDate();
            }
        }

        public void PrintAll()
        {
            foreach (Customer customers in customers)
            {
                Console.WriteLine(customers);
            }
        }
        void printMenu()
        {
            readCustomerData();
            int choice = 0;
            do
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Select the Choices");
                Console.WriteLine("1. Print all the data of customeres");
                Console.WriteLine("2. Select customer by Id");
                Console.WriteLine("3. Change the phone number");
                Console.WriteLine("4. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PrintAll();
                        break;
                    case 2:
                        PrintCustomer();
                        break;
                    case 3:
                        UpdateCustomer();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (choice!=4);
        }

        private void UpdateCustomer()
        {
            Console.WriteLine("Please enter the Id");
            int id = 0;
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalied Entry. please try again");
            }
            Customer customer = GetCustomerById(id);
            if (customer != null)
            {
                Console.WriteLine("customer");
                Console.WriteLine("Please enter the new phone number");
                string phone = Console.ReadLine();
                customer.phone = phone;
            }
            else
            {
                Console.WriteLine("No such customer");
            }
        }

        private void PrintCustomer()
        {
            Console.WriteLine("Please enter the Id");
            int id = 0;
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalied Entry. please try again");
            }
            Customer customer = GetCustomerById(id);
            if (customer != null)
            {
                Console.WriteLine(customer);
            }
            else
            {
                Console.WriteLine("No such customer");
            }
        }

        private Customer GetCustomerById(int id)
        {
            Customer customer = null;
            for (int i = 0; i < customers.Length; i++)
            {
                if(customers[i].Id == id)
                {
                    customer = customers[i];
                    break;
                }
            }
            return customer;
        }

        static void Main(string[] a)
        {
            CustomerRepo repo = new CustomerRepo(3);
            repo.printMenu();
            Console.ReadKey();
        }
    }
}