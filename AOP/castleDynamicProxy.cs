using System;
using ClassLibrary;
using Castle.DynamicProxy;
namespace AOP
{
    public class castleDynamicProxy
    {
        public castleDynamicProxy()
        {
            Console.WriteLine("****castleDynamicProxy****");
            People people = new People()
            {
                Id = 1,
                Name = "castleDynamicProxy",
                Age = 12
            };

            ProxyGenerator generator = new ProxyGenerator();

            MyIntercepter intercepter = new MyIntercepter();
            Decorates decorates = generator.CreateClassProxy<Decorates>(intercepter);

            decorates.Exec(people);
        }
    }

    public interface IDecorate
    {
        void Exec(People people);
    }

    public class Decorates : IDecorate
    {
        /// <summary>
        /// 必须带上 virtual
        /// </summary>
        /// <param name="people"></param>
        public virtual void Exec(People people)
        {
            Console.WriteLine(" castleDynamicProxy 方法 New 一个新" + people.Name);
        }
    }

    public class MyIntercepter : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            PreProcess();
            invocation.Proceed();
            PostProcess();
        }

        private void PostProcess()
        {
            Console.WriteLine("后一个方法");
        }

        private void PreProcess()
        {
            Console.WriteLine("前一个方法");
        }
    }
}
