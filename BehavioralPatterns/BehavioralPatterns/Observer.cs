using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns
{
    public class Observer:IObserver
    {
        public string ObserverName { get; private set; }

        public Observer(string name)
        {
            ObserverName = name;
        }

        public void Update()
        {
            Console.WriteLine($"{this.ObserverName}--->Mail has arrived!");
        }
    }

    interface IObserver
    {
        void Update();
    }
}
