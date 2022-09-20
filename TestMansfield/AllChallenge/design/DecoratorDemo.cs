using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.design
{
    public interface IComponent
    {
        int Cost();
    }

    public class ConcreteComponent : IComponent
    {
        public int Cost()
        {
            return 1;
        }
    }

    public class Decorator1: IComponent
    {
        public IComponent _com;
        public Decorator1(IComponent com)
        {
            _com = com;
        }

        public int Cost ()
        {
            return 10 + _com.Cost();
        }
    }

    public class Decorator2 : IComponent
    {
        public IComponent _com;
        public Decorator2(IComponent com)
        {
            _com = com;
        }

        public int Cost()
        {
            return 100 + _com.Cost();
        }
    }


    public class DecoratorClient
    {
        public static void Run()
        {
            IComponent com = new ConcreteComponent();

            IComponent com1 = new Decorator1(com);

            IComponent com2 = new Decorator2(com1);

            Console.WriteLine(com2.Cost());
        }
    }
}
