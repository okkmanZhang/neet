using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.design
{
    public interface IDuck
    {
        void Fly();
    }
    public interface ITurkey
    {
        void SlowFly();
    }
    public interface IDuckTurkeyAdapter : IDuck
    {
    }

    public class Duck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine($"{this.GetType().Name}.{nameof(Fly)}");
        }
    }

    public class Turkey: ITurkey
    {
        public void SlowFly() => Console.WriteLine($"{this.GetType().Name}.{nameof(SlowFly)}");
    }

    public class DuckTurkeyAdapter : IDuckTurkeyAdapter
    {
        private ITurkey _turkey;
        public DuckTurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public void Fly() => _turkey.SlowFly();

    }

    public class AdapterClient
    {
        public static void Test()
        {
            IDuck duckTurkey = new DuckTurkeyAdapter(new Turkey());
            duckTurkey.Fly();
        }
    }


}
