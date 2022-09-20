using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.design
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void Update(string msg);
    }

    public class Subject : ISubject
    {
        private IList<IObserver> _observers = new List<IObserver>();
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var obs in _observers)
            {
                obs.Update("from subject");
            }
        }
    }

    public class Observer1 : IObserver
    { 
        public void Update(string msg)
        {
            Console.WriteLine($"{nameof(Observer1)}: {msg}");
        }
    }

    public class Observer2 : IObserver
    {
        public void Update(string msg)
        {
            Console.WriteLine($"{nameof(Observer2)}: {msg}");
        }
    }

    public class SubjectDemo
    {
        public static void Run()
        {
            ISubject sub = new Subject();
            IObserver ob1 = new Observer1();
            IObserver ob2 = new Observer2();

            sub.RegisterObserver(ob1);
            sub.RegisterObserver(ob2);

            sub.Notify();

        }
    }

}


