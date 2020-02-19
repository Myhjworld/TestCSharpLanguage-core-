using System;
using TestCSharpLanguage.Linq;
using AOP;

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
                //LinqToSql linqToSql = new LinqToSql();
            }
            {
                Console.WriteLine("**************DesignModel***************");
                //DesignModel.Decorate.DecorateAOP aOP = new DesignModel.Decorate.DecorateAOP();
            }
            {
                Console.WriteLine("**************AOP***************");
                Decorate decorate = new Decorate();
                Agent agent = new Agent();
                RealProxyAOP realProxyAOP = new RealProxyAOP();
                castleDynamicProxy castleDynamicProxy = new castleDynamicProxy();
            }
        }
    }
}
