using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFA13
{
    class Program
    {
        public static void find(int a)
        {
            if(a < 0)
            {
                throw new NotFoundException(a + "不存在");
            }
        }
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = Convert.ToInt32("123a5");
            //    Console.WriteLine("结果为：" + a);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("出错 :" + e.Message);
            //}
            try
            {
                find(-10);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
