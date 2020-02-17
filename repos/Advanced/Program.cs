using System;

namespace Advanced
{
    //------ISP Problem-----
     public interface IDevice
     {
         void Scan();
         void Print();
     }
     public class Scanner : IDevice
     {
         public void Scan()
         {
             Console.WriteLine("Scanner");
         }
         public void Print()
         {
             //throw new NotImplementedException();
         }
     }
     public class Printer : IDevice
     {
         public void Print()
         {
             Console.WriteLine("Printer");
         }
         public void Scan()
         {
             //throw new NotImplementedException();
         }
     }
    //------------ISP Solution------
    
    public interface IPrinter
    {
        void Print();
    }
    public interface IScanner
    {
        void Scan();
    }
    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printer");
        }
    }
    public class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scanner");
        }
    }
    public interface IMultiFunctionalDevice : IPrinter, IScanner
    {
        // public void Scan_Print();
    }
    public class MultiFunctionalDevice : IMultiFunctionalDevice
    {
        public void Scan()
        {
            Console.WriteLine("Multi functional device scans");
        }
        public void Print()
        {
            Console.WriteLine("Multi functional device prints");
        }
        //-----OCP---
        /* public void Scan_Print()
         {
             Console.WriteLine("Multi functional device prints and scans");
         }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // MultiFunctionalDevice super_printer = new MultiFunctionalDevice();
            //super_printer.Scan_Print();
        }
    }
}
