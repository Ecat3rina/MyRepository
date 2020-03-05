using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Computer
    {
        public OperatingSystem OS { get; set; }
        public void Launch(string OSName)
        {
            OS = OperatingSystem.Instance(OSName);
        }
    }
}
