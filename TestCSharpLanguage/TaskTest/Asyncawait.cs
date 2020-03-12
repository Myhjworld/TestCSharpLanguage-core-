using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestCSharpLanguage.TaskTest
{
    public class Asyncawait
    {
        public  Asyncawait()
        {
            Console.WriteLine("**************Asyncawait*************");
            //Task task = new Task(() =>
            //{
            //    Console.WriteLine($"This Thread {Thread.CurrentThread.ManagedThreadId.ToString("00")}");
            //});
            //TestAsync();
            Console.WriteLine("**************AsyncawaitEnd*************");
            //task.Wait();
        }

        public async Task TestAsync()
        {
            TaskFactory taskFactory = new TaskFactory();
            await Task.Run(() =>
            {
                Console.WriteLine($"This Thread {Thread.CurrentThread.ManagedThreadId.ToString("00")}");
            });
            
        }
    }
}
