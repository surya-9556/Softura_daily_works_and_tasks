using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Manager:IManagerPersonal,IEmployeeManager,ICustomerManager
    {
        public void Eat()
        {
            Console.WriteLine("Manager eates");
        }
        public void sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZ");
        }
        public void ConductsStaffMeeting()
        {
            Console.WriteLine("Conducts Meeting.....!");
        }
        public void ApproveLoan()
        {
            Console.WriteLine("Approves Loan");
        }
        public void ResolveCustomerIssues()
        {
            Console.WriteLine("Resolves the customer issues");
        }
        public void HandelsEmployee()
        {
            Console.WriteLine("Handles Employee");
        }
    }
}
