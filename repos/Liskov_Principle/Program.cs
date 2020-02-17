using System;

namespace Liskov_Principle
{
    class Square_Prism
    {
        //length=width
        public virtual int Length
        {
            get;
            set;
        }
        public virtual int Height
        {
            get;
            set;
        }

        public int Calculate_Area()
        {
            return Length * Length * Height;
        }
    }

    class Cube : Square_Prism
    {
        public override int Length
        {
            set { base.Length = base.Height = value; }
        }
        public override int Height
        {
            set { base.Height = base.Length = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Square_Prism pris = new Square_Prism() { Height = 2, Length = 4 };
            Console.WriteLine(pris.Calculate_Area());
            Square_Prism c = new Cube() { Height = 2, Length = 4 };
            Console.WriteLine(c.Calculate_Area());
        }
    }
}