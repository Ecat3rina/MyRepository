using System;

namespace Liskov_Principle
{
    public interface IArea
    {
        int Calculate_Area();
    }
    class Square_Prism : IArea
    {
        //length=width
        public int Length
        {
            get;
            set;
        }
        public int Height
        {
            get;
            set;
        }

        public virtual int Calculate_Area()
        {
            return Length * Length * Height;
        }
    }

    class Cube : Square_Prism, IArea
    {
        public int Length
        {
            set;
            get;
        }
        public override int Calculate_Area()
        {
            return Length * Length * Length;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Square_Prism pris = new Square_Prism() { Height = 2, Length = 4 };
            Console.WriteLine(pris.Calculate_Area());
            Cube c = new Cube() { Length = 4 };
            Console.WriteLine(c.Calculate_Area());
        }
    }
}
