using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace FacadePattern
{
    public class Database
    {
        private Database()//防止外部new出Database的实例
        {

        }

        /// <summary>
        /// 模拟数据库，返回Dictionary<string,string> 数据
        /// </summary>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetProperties(string dbName)
        {
            string fileName = dbName + ".txt";
            Dictionary<string, string> prop = new Dictionary<string, string>();
            try
            {
                prop.Add("db", dbName);
                prop.Add("tomura@hyuki.com", "Tomura");
            }
            catch (Exception)
            {
                WriteLine($"Warning:{fileName} is not found.");
            }
            return prop;
        }
    }
}
