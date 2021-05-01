using System;
using System.Collections.Generic;
using System.Text;

namespace UndersatandingOOPS
{
    class Phone
    {
        string ringToneName; //variable
        public string color { get; set; }//property
        public Phone() => Console.WriteLine("Phone created");
        public void CheckWorkPublic()
        {
            Console.WriteLine("Public Method");
        }
        protected void CheckWorkProtected()
        {
            Console.WriteLine("Protected Method");
        }
        private void CheckWorkPrivate()
        {
            Console.WriteLine("Private Method");
        }
        internal void CheckWorkInternal()
        {
            Console.WriteLine("Internal Method");
        }
    }
}
