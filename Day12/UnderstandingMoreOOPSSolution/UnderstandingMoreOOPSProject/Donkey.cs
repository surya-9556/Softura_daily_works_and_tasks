using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Donkey : Animals
    {
        public Donkey()
        {
            Console.WriteLine("It's a donkey");
        }
        public override void Move()
        {
            Console.WriteLine("Tok..Tok..Tok..Tok");
        }
    }
}
