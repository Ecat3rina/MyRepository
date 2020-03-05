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
            set { base.Length = base.Length = value; }
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
            ProcessData(new Square_Prism());
            ProcessData(new Cube());

            //Console.WriteLine(pris.Calculate_Area());
          
        }

        static void ProcessData(Square_Prism square_Prism)
        {
            square_Prism.Height = 2;
            square_Prism.Length = 4;

            Console.WriteLine(square_Prism.Calculate_Area());

            //Another processing
        }
    }
}