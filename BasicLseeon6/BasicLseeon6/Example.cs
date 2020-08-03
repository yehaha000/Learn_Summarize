using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLseeon6
{
    class Example
    {
        public int number;

        public void Output()
        {
            Console.WriteLine("number:" + number);
        }

        public virtual void Translate()
        {
            Console.WriteLine("number:" + number);
        }
    }
}
