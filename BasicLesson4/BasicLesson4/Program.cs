using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 添加类
            Student stu = new Student();
            stu.id = 202000001;
            stu.name = "Bob";
            stu.sex = true;
            stu.phone = "12134545";
            Console.WriteLine("学号:{0},姓名:{1},性别:{2},手机号:{3}", stu.id, stu.name, stu.sex ? "男" : "女", stu.phone);


            // 2. 创建Example类的实例对象
            Example ex = new Example();
            ex.number += 3;
            ex.Output();
            ex.Output("重载演示");


            // 3. 构造方法
            Constructor c1 = new Constructor();
            Constructor c2 = new Constructor(2020);
            Constructor c3 = new Constructor(2020,"冲呀！！！");

            // 4. 类的拆分
            MyForm form = new MyForm();
            form.buttonText = "保存";
            form.UserPressButton();
        }
    }

    class Example
    {
        // 定义属性
        public int number = 10;
        // 定义方法，方法名一般是大写
        public void Output()
        {
            Console.WriteLine("number:" + number);
        }
        // 支持方法重载，只要参数不一样
        public void Output(string abc)
        {
            Console.WriteLine(abc);
        }
    }
}
