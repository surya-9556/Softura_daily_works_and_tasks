using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Horse : Animals
    {
        public Horse()
        {
            Console.WriteLine("Its a horse");
        }
        public override void Move()
        {
            Console.WriteLine("Tik..Tik..Tik..Tik..");
        }
    }
}
