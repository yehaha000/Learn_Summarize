using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFA13
{
    class NotFoundException : Exception
    {
        public NotFoundException()
        {

        }
        public NotFoundException(string message): base(message)
        {

        }
    }
}
