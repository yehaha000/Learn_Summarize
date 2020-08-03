using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson4
{
    class Constructor
    {
        public int id;
        public string name;
        public bool sex;
        public string phone;

        public Constructor()
        {

        }

        public Constructor(int id)
        {
            this.id = id;
        }

        public Constructor(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
