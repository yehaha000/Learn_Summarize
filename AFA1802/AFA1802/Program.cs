using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace AFA1802
{
    class Program
    {
        public static string CreateJSON()
        {
            JObject j = new JObject();
            j["id"] = 2020001;
            j["name"] = "邵发";
            j.Add("sex", true);
            j.Add("phone", "13810012345");

            JArray colors = new JArray();
            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");
            j.Add("colors", colors);

            return j.ToString();
        }
        static void Main(string[] args)
        {
            // 给定一个JSON字符串
            // 实际项目中，这个字符串可能是从文件、数据库或者网站上获取
            string jsonstr = CreateJSON();

            // String -> JObject
            JObject j2 = JObject.Parse(jsonstr);

            // 提取各个字段
            int id = (int)j2["id"];
            bool sex = (bool)j2["sex"];
            Console.WriteLine("学号: " + id + ", 性别" + sex);

            // 判断一个字段是否存在
            if (j2.ContainsKey("name"))
            {
                string name = (string)j2.GetValue("name");
                Console.WriteLine("姓名:" + name);
            }

            // 取得一个 Array
            JArray colors = (JArray)j2["colors"];
            for (int i = 0; i < colors.Count; i++)
            {
                string c = (string)colors[i];
                Console.WriteLine("color:" + c);
            }
        }
    }
}
