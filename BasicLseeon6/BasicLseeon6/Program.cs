using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLseeon6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.继承
            MyExample ex = new MyExample();
            ex.number = 123;
            ex.Output();
            ex.Translate();

            // 2.多态
            // 创建了Example对象，但实际引用类型是MyExample。实际指向对象为MyExample
            Example e = new MyExample();
            e.number = 456;
            e.Translate(); // 调用的是实际指向对象的方法。即MyExample中的方法

            
          }
    }

    // 3. 构造方法的继承
    public class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Point3D : Point
    {
        public int z;
        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
}
