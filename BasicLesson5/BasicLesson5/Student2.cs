using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson5
{
    class Student2
    {
        // 自动属性，编译器会自动补充
        public string Name { get; set; }

        /* 补充后结果：
        private string xxx;  
        public String Name
        {
            get
            {
                return this.xxx;
            }
            set
            {
                this.xxx = value;
            }
        }
        */
    }
}
