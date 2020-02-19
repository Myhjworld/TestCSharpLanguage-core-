using System;
using ClassLibrary;

namespace AOP
{
    public class Decorate
    {
        public Decorate()
        {
            Console.WriteLine("****decorate****");
            People people = new People()
            {
                Id = 1,
                Name = "decorate",
                Age = 12
            };

            IDecorate decorate = new Decorates();
            decorate.Exec(people);

            decorate = new DecDecorate(decorate);
            decorate.Exec(people);
        }

        public interface IDecorate
        {
            public void Exec(People people);
        }

        public class Decorates : IDecorate
        {
            public void Exec(People people)
            {
                Console.WriteLine("New 一个新" + people.Name);
            }
        }

        public class DecDecorate : IDecorate
        {
            private IDecorate _decorate { get; set; }

            public DecDecorate(IDecorate decorate)
            {
                this._decorate = decorate;
            }

            public void Exec(People people)
            {
                BeforeDec();

                this._decorate.Exec(people);

                AfterDec();
            }

            private void AfterDec()
            {
                    
            }

            private void BeforeDec()
            {
                Console.WriteLine("后一个方法");
            }
        }
    }
}
