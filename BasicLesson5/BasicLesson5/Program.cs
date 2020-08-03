using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Getter / Setter
            Student stu = new Student();
            stu.SetName("小明");
            Console.WriteLine("姓名：" + stu.GetName());

            // 2. 添加属性
            Student1 stu1 = new Student1();
            stu1.Name = "小红";
            Console.WriteLine("姓名：" + stu1.Name);

            // 3. 自动属性
            Student2 stu2 = new Student2();
            stu2.Name = "小李";
            Console.WriteLine("姓名：" + stu2.Name);
        }
    }
}
