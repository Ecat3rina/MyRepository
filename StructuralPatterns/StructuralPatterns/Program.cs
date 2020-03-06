using System;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region proxy

            IInternetAccess access = new ProxyInternetAccess("User 123");
            access.grantInternetAccess();

            #endregion

            #region Facade

            OrderCar order = new OrderCar();
            order.OpenDoor();
            order.CloseDoor();
            order.ConnectBluetooth();
            order.CallContact();
            order.DisconnectBluetooth();


            #endregion

            #region decorator

            BasicCalculator calculator = new BasicCalculator();
            Console.WriteLine("Regular Calculator:");
            Console.WriteLine(calculator.Add(4, 3));
            BetterCalculator betterCalculator = new BetterCalculator(calculator);
            Console.WriteLine("Decorated Calculator:");
            Console.WriteLine(betterCalculator.Add(4, 3));
            Console.WriteLine("Also subtract");
            //Console.WriteLine(betterCalculator.Subtract(4, 3));
            ScientificCalculator scientificCalculator = new ScientificCalculator(betterCalculator);
            Console.WriteLine("Scientific Calculator:");
            Console.WriteLine(scientificCalculator.Add(4, 3));         
            Console.WriteLine("Also multiply");
          //  Console.WriteLine(scientificCalculator.Multiply(4, 3));
            #endregion

        }
    }
    abstract class Calculator
    {
        public abstract int Add(int x, int y);
    }
    class BasicCalculator : Calculator
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }
    }
    
    class Decorator : Calculator
    {
        Calculator myCalc { get; set; }

        public Decorator(Calculator calculator)
        {
            this.myCalc = calculator;
        }

        public override int Add(int x, int y)
        {
            return this.myCalc.Add(x, y);
        }
    }

    class BetterCalculator : Decorator
    {
        public BetterCalculator(Calculator calc) : base(calc) { }

        public override int Add(int x, int y)
        {
            return base.Add(x,y)+2;
        }
        //public int Subtract(int x, int y)
        //{
        //    return x - y;
        //}
    }
    class ScientificCalculator : Decorator
    {
        public ScientificCalculator(Calculator calc) : base(calc) { }

        public override int Add(int x, int y)
        {
            return base.Add(x, y) + 10;
        }
        //public int Multiply(int x, int y)
        //{
        //    return x * y;
        //}
    }
}

