using System;
using System.ComponentModel;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Lazy<SixthAttempt.Singleton> ob1 = new Lazy<SixthAttempt.Singleton>();
            SixthAttempt.Singleton ob2 = ob1.Value;
            ob1.Value < -0;
            Console.WriteLine(ob1.Value);
        }
    }
}
