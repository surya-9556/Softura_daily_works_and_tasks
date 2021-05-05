using System;
using System.Collections.Generic;
using System.Text;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    public class EmployeeLogin
    {
        ILogin<Employee> Repo;

        public EmployeeLogin(ILogin<Employee> repo)
        {
            Repo = repo;
        }

        public EmployeeLogin()
        {
            Repo = new EmployeeRepo();
        }

        public void Register()
        {
            Employee employee = CreateEmployee();
            Repo.Add(employee);
        }

        public Employee CreateEmployee()
        {
            Employee employee = new Employee();
            employee.GetEmployeeDetails();
            return employee;

        }
        public void Login()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter the username");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Password");
            employee.Password = Console.ReadLine();
            if (Repo.Login(employee))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Invalied User");
            }
        }
    }
}
