using System;
using TestCSharpLanguage.Linq;
using AOP;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace TestCSharpLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"测试");


            var ds = new DataStruct.DataStruct();
            ds.DataStructList();

        }

        public static void switchs(string x)
        {
            switch (x)
            {
                case "hj" when x.Substring(0,1) == "x":
                    Console.WriteLine(x);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
                case null:
                    Console.WriteLine("null");
                    break;
            }
        }

        public static (string s, int i, double d) getvalue()
        {
            return ("hj", 1, 1.1);
        }

        public static void get(out int i, out string j)
        {
            i = 11;
            j = "hj";
        }

        public static void get2(ref int i, out string j)
        {
            i = 11;
            j = "hj";
        }

        public void Test()
        {
            {
                //var user = new
                //{
                //    name = "hj",
                //    age = 20
                //};
                //string userinfo = Newtonsoft.Json.JsonConvert.SerializeObject(user);
                //var users = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(userinfo);
                //Console.WriteLine(users["name"]);
                //int x = 1;
                //get2(ref x, out string y);
                //get(out int i, out var j);
                //Console.WriteLine($"i={i + 1},j={{{j}}}");

                //var result = getvalue();
                //Console.WriteLine($"{result.s},{result.i},{result.d}"  );
                //var result2 = getvalue();
                //Console.WriteLine($"{result2.Item1},{result.i},{result.d}");

                //int i = 1_000_000;
            }
            //{
            //    Console.WriteLine("Hello World!");
            //    Console.WriteLine("Test C# Languages");
            //    string name = "hj";
            //    Console.WriteLine($"{name} 的测试项目！");
            //}
            //{
            //    Console.WriteLine("*************LinqToSql*************");
            //    //LinqToSql linqToSql = new LinqToSql();
            //}
            //{
            //    Console.WriteLine("**************DesignModel***************");
            //    //DesignModel.Decorate.DecorateAOP aOP = new DesignModel.Decorate.DecorateAOP();
            //}
            //{
            //    Console.WriteLine("**************AOP***************");
            //    Decorate decorate = new Decorate();
            //    Agent agent = new Agent();
            //    RealProxyAOP realProxyAOP = new RealProxyAOP();
            //    castleDynamicProxy castleDynamicProxy = new castleDynamicProxy();
            //}
            //{
            //    string abc = "abc";
            //    String bcd = abc;
            //    StringBuilder sb = new StringBuilder();
            //    sb.Append("2131");
            //    sb.Append("456");
            //    String str = sb.ToString();
            //    String.IsNullOrEmpty("111");
            //}
            //{
            //    Console.WriteLine("*************线程*************");
            //    Console.WriteLine($"当前线程name:{Thread.CurrentThread.ManagedThreadId.ToString("00")},执行时间：{DateTime.Now.ToString()}");
            //    ThreadStart start = () => { Console.WriteLine($"线程{Thread.CurrentThread.ManagedThreadId.ToString("00")}启动!"); };
            //    Thread thread = new Thread(start);
            //    thread.Start();

            //    ThreadPool.QueueUserWorkItem(O =>
            //    {
            //        Console.WriteLine($"线程{Thread.CurrentThread.ManagedThreadId.ToString("00")}的线程池启动!");
            //    }, "线程池");
            //    Thread.Sleep(3000);
            //    Console.WriteLine($"当前线程name:{Thread.CurrentThread.ManagedThreadId.ToString("00")},执行时间：{DateTime.Now.ToString()}");

            //}
            //{
            //    Console.WriteLine("*************线程Task*************");
            //    Task task = new Task(() => Console.WriteLine("111"));
            //    task.Start();
            //    Task.Run(() => Console.WriteLine("111"));
            //    TaskFactory taskFactory = Task.Factory;
            //    Task task1 = taskFactory.StartNew(() => Console.WriteLine("111"));
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();
            //    Thread.Sleep(2000);
            //    stopwatch.Stop();
            //    Console.WriteLine($"stopwatch时间{stopwatch.ElapsedMilliseconds}");
            //}
            //{
            //    Console.WriteLine("*******临时变量******");
            //    for (int i = 0; i < 5; i++)
            //    {

            //        int k = i;
            //        Task.Run(() =>
            //        {
            //            Console.WriteLine($"执行线程_{i}_{k}");
            //        });
            //    }
            //}
            //{
            //    string a = "123";
            //    string b = "123";
            //    string c = b;
            //    b = "234";
            //    Console.WriteLine($"a={a},b={b},c={c}");
            //    Task task=new Task(()=>{
            //        System.Console.WriteLine($"a={a}");
            //    });
            //}
            //{
            //    Base.ArrayList arrayList = new Base.ArrayList();
            //}
            //{
            //    TaskTest.Asyncawait asyncawait = new TaskTest.Asyncawait();
            //}
        }
    }
}
