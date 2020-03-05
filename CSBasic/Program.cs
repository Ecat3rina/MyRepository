using System;
using System.Threading;

namespace ConsoleApp1
{
    class ThreadTest
    {
        public static void thread1method()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("1");
        }
        public static void thread2method()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("2");
        }
    }
    class Constructor
    {
        static Constructor()
        {
            Console.WriteLine("Static Constructor Called");
        }
        public Constructor()
        {
            Console.WriteLine("Default Constructor Called");
        }
    }
    class Program
    {
        public static void modify(int a, int b, out int c)
        {
            c = a + b;
        }
        public static void modify(ref int a, ref int b)
        {
            a += 2;
            b += 3;
        }
        public static void modify(int a, int b)
        {
            a += 2;
            b += 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hellor World");
            int x = 2, y = 7;
            //no parameter modifier
            Console.WriteLine("Before modify method x=" + x + " y=" + y);
            modify(x, y);
            Console.WriteLine("After modify method x=" + x + " y=" + y);
            //ref parameter
            Console.WriteLine("Before modify_ref method x=" + x + " y=" + y);
            modify(ref x, ref y);
            Console.WriteLine("After modify_ref method x=" + x + " y=" + y);
            //out parameter
            int z;
            modify(x, y, out z);
            Console.WriteLine("After modify_out method x=" + x + " y=" + y + " z=" + z);
            //boxing
            Object obj = z;
            Console.WriteLine("After boxing " + obj);
            //unboxing
            int unb = (int)obj;
            Console.WriteLine("After unboxing " + unb);
            //-------static constructor-----
            Constructor cons1 = new Constructor();
            //-------threds------------
           
            Thread t1 = new Thread(ThreadTest.thread1method);
            Thread t2 = new Thread(ThreadTest.thread2method);
            t1.Start();
            t2.Start();
            Console.ReadLine();
            int.TryParse("dasd", out var ttt);
        }
    }
}

