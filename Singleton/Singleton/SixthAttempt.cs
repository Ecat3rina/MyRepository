using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   public class SixthAttempt
    {
        public sealed class Singleton
        {
            private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton(), true);

            public static Singleton Instance
            {
                get
                {
                    return lazy.Value;
                }
            }

            private Singleton()
            {
            }
        }

    }
}
