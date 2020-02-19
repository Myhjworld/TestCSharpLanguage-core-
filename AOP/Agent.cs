using System;
using ClassLibrary;
namespace AOP
{
    public class Agent
    {
        public Agent()
        {
            Console.WriteLine("****agent****");
            People people = new People()
            {
                Id = 1,
                Name = "agent",
                Age = 12
            };

            IAgent agent = new Agents();
            agent.Exec(people);

            agent = new AgAgents();
            agent.Exec(people);
        }

        public interface IAgent
        {
            public void Exec(People people);
        }

        public class Agents : IAgent
        {
            public void Exec(People people)
            {
                Console.WriteLine("New 一个新" + people.Name);
            }
        }

        public class AgAgents : IAgent
        {
            IAgent _agen = new Agents();

            public AgAgents()
            {

            }

            public void Exec(People people)
            {
                BeforeAg();

                _agen.Exec(people);

                AfterAg();
            }

            private void AfterAg()
            {
                Console.WriteLine("前一个方法");
            }

            private void BeforeAg()
            {
                Console.WriteLine("后一个方法");
            }
        }
    }
}
