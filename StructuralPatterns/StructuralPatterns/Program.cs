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

            Calculator calculator = new Calculator();
            Console.WriteLine("Regular Calculator:");
            Console.WriteLine(calculator.Add(4, 3));
            BetterCalculator betterCalculator = new BetterCalculator(calculator);
            Console.WriteLine("Decorated Calculator:");
            Console.WriteLine(betterCalculator.Add(4, 3));
            Console.WriteLine("Also subtract");
            Console.WriteLine(betterCalculator.Subtract(4, 3));
            ScientificCalculator scientificCalculator = new ScientificCalculator(calculator);
            Console.WriteLine("Scientific Calculator:");
            Console.WriteLine(scientificCalculator.Add(4, 3));
            Console.WriteLine("Also subtract");
            Console.WriteLine(scientificCalculator.Subtract(4, 3));
            Console.WriteLine("Also multiply");
            Console.WriteLine(scientificCalculator.Multiply(4, 3));
            #endregion

        }
    }
    class Calculator : ICalculator
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }
    }
    abstract class ICalculator
    {
        public abstract int Add(int x, int y);
    }
    class Decorator : ICalculator
    {
        ICalculator myCalc { get; set; }

        public Decorator(ICalculator calculator)
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
        public BetterCalculator(ICalculator calc) : base(calc) { }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    class ScientificCalculator : BetterCalculator
    {
        public ScientificCalculator(ICalculator calc) : base(calc) { }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}

