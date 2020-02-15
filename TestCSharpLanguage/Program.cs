using System;
using TestCSharpLanguage.Linq;

namespace TestCSharpLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Test C# Languages");
                string name = "hj";
                Console.WriteLine($"{name} 的测试项目！");
            }
            {
                Console.WriteLine("*************LinqToSql*************");
                LinqToSql linqToSql = new LinqToSql();
            }

        }
    }
}
