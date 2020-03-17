using System;
using FluentScheduler;
namespace MVC.Task
{
    public class Registrys : Registry
    {
        public Registrys()
        {
            Schedule(() => Console.WriteLine($"this is while {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}")).ToRunNow().AndEvery(5).Seconds();
        }
    }
}
