using System;
using System.Collections.Generic;

namespace TestCSharpLanguage.DataStruct
{
    public class DataStruct
    {
        public DataStruct()
        {
        }
        public void DataStructList()
        {
            //{
            //    Console.WriteLine("**************集合*set*HashSet**************");
            //    Console.WriteLine("*****vs****");
            //    HashSet<int> vs = new HashSet<int>();
            //    vs.Add(1);
            //    vs.Add(2);
            //    vs.Add(2);
            //    vs.Add(3);
            //    foreach (var item in vs)
            //    {
            //        Console.WriteLine($"vs:{item }");
            //    }
            //    Console.WriteLine("****vs2***");
            //    HashSet<int> vs2 = new HashSet<int>();
            //    vs2.Add(3);
            //    vs2.Add(4);
            //    vs2.Add(4);
            //    vs2.Add(5);
            //    foreach (var item in vs2)
            //    {
            //        Console.WriteLine($"vs:{item }");
            //    }
            //    Console.WriteLine("****func***");
            //    vs.IntersectWith(vs2);
            //    vs.ExceptWith(vs2);
            //    vs.UnionWith(vs2);
            //    vs.SymmetricExceptWith(vs2);
            //    Console.WriteLine("**************集合*set*SortSet(会自动排序，按照对象类型)**************");
            //}
            //{
            //    Console.WriteLine("**************Queue**************");
            //    Queue<int> vs = new Queue<int>();
            //    vs.Enqueue(1);
            //    vs.Enqueue(3);
            //    vs.Enqueue(2);
            //    vs.Enqueue(4);
            //    Console.WriteLine(vs.Peek());
            //    vs.Dequeue();
            //    Console.WriteLine(vs.Peek());
            //}
            //{
            //    Console.WriteLine("**************stack**************");
            //    Stack<int> vs = new Stack<int>();
            //    vs.Push(1);
            //    vs.Push(3);
            //    vs.Push(2);
            //    vs.Push(4);
            //    Console.WriteLine(vs.Peek());
            //    vs.Pop();
            //    Console.WriteLine(vs.Peek());
            //}
            {
                YieldDemo yieldDemo = new YieldDemo();
                foreach (var item in yieldDemo.Power())
                {
                    Console.WriteLine(item);
                    if (item > 100)
                    {
                        break;
                    }
                }
            }
        }
    }
}
