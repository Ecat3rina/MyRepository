using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class OperatingSystem
    {
        private static OperatingSystem instance = null;
        private static readonly object padlock = new object();
        public string Name { get; private set; }
        private OperatingSystem(string name) 
        {
            this.Name = name;
        }

        public static OperatingSystem Instance(string name)
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new OperatingSystem(name);
                    }
                }
            }
            return instance;
        }
    }
}
