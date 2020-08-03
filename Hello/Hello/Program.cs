using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 10;
            int b = a * 3;
            // 字符串的拼接
            Console.WriteLine("结果为：" + b);
            // 字符串的格式化
            //{0}表示第一个参数，{1}为第2个参数
            string str = string.Format("中招:{0},痊愈:{1}", 1932, 39);
            Console.WriteLine(str);
            // 效果一样
            Console.WriteLine("中招:{0},痊愈:{1}", 1932, 39);
        }
    }
}
