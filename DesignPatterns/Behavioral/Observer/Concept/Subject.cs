using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Concept
{
    public class Subject : ISubject
    {
        public int State { get; set; }
        List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("#Attached observer...>]");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {            
            _observers.Remove(observer);
            Console.WriteLine("#Detached observer...]>");
        }

        public void Notify()
        {
            Console.WriteLine("#Notifying observers...[>>>]");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
