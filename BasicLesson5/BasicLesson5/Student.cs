using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson5
{
    class Student
    {
        // 设为private，默认都不能访问
        // 然后通过Get / Set 方法访问
        private string name;

        // Getter，让外界可以读写字段
        public string GetName ()
        {
            return this.name;
        }

        // Setter，让外界可以设置字段
        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
