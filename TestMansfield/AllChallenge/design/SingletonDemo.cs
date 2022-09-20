using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.design
{
    public class Singleton
    {
        private static Singleton _singleton;
        private Singleton() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton GetInstance()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }

            return _singleton;
        }

        public void Test()
        {
            Console.WriteLine($"{_singleton.GetHashCode()}");
        }
    }

    public class SingletonClient
    {        
        public static void Run()
        {
            var singleton = Singleton.GetInstance();
            singleton.Test();
        }
    }
}
