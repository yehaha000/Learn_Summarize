using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson5
{
    class Student1
    {
        private string name;
        // public是代表可访问性， String是类型，Name是属性名
        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value; // 关键字，就是传进来的值 
            }
        }
    }
}
