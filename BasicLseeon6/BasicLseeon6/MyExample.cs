using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLseeon6
{
    class MyExample : Example
    {
        public override void Translate()
        {
            // 调用父类中方法用base
            base.Translate();
            Console.WriteLine("数字是：" + number);
        }
    }
}
