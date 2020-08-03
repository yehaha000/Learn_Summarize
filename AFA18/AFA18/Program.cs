using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace AFA18
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject J = new JObject();
            J["id"] = 2020001;
            J["name"] = "张三";
            J.Add("sex", true);
            J.Add("phone", "23454856");

            JArray colors = new JArray();
            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");
            J.Add("colors", colors);

            string jsonstr = J.ToString();
            Console.WriteLine(jsonstr);

            Console.WriteLine("Exit");
        }
    }
}
