using System;
using System.Reflection;
using ClassLibrary;
namespace AOP
{
    public class RealProxyAOP
    {
        public RealProxyAOP()
        {
            Console.WriteLine("RealProxy 已经被.Net Core遗弃");
            //Console.WriteLine("****decorate****");
            //People people = new People()
            //{
            //    Id = 1,
            //    Name = "Proxy",
            //    Age = 12
            //};

            //IPeopleProcesser peopleProcesser = new PeopleProcesser();
            //peopleProcesser.Exec(people);


        }


    }

    //public class MyRealProxy<T>: DispatchProxy
    //{
    //    public MyRealProxy(T t)
    //    {

    //    }

    //    protected override object Invoke(MethodInfo targetMethod, object[] args)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public static class TransparentProxy
    //{
    //    public static T Create<T>()
    //    {
    //        T instace = Activator.CreateInstance<T>();
    //        MyRealProxy<T> myRealProxy = new MyRealProxy<T>(instace);
    //        T transparentProxy=(T)
    
    //    }
    //}
    //public interface IPeopleProcesser
    //{
    //    public void Exec(People people);
    //}

    ///// <summary>
    ///// 可序列化父类：MarshalByRefObject
    ///// </summary>
    //public class PeopleProcesser : MarshalByRefObject, IPeopleProcesser
    //{
    //    public void Exec(People people)
    //    {
    //        Console.WriteLine("*********RealProxy*********");
    //    }
    //}
}
