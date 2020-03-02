using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class ThirdAttempt
    {
        public sealed class Singleton
        {
            private static Singleton instance = null;
            private static readonly object padlock = new object();

            Singleton()
            {
            }

            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (padlock)
                        {
                            if (instance == null)
                            {
                                instance = new Singleton();
                            }
                        }
                    }
                    return instance;
                }
            }
        }
    }
}
