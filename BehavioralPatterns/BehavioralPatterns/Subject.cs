using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns
{
    public class Subject:ISubject
    {
        private List<Observer> observers=new List<Observer>();
        private int count;

        public int Inventory
        {
            get { return count; }
            set
            {
                if (value > count)
                    Notify();
                count = value;
            }
        }

        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
            Console.WriteLine($"A new observer called  {observer.ObserverName}!");
        }
        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
            Console.WriteLine($"Observer {observer.ObserverName} has been removed");
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    interface ISubject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify();
    }
}
