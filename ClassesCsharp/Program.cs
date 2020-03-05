/*using System;

namespace ClassesCsharp
{
    class Vehicle
    {
        enum Type
        {
            car, motorcycle
        }
        public int wheel_nr;
        Type type;
        public Vehicle() { }
        public Vehicle(int nr)
        {
            wheel_nr = nr;
        }
        public string Name
        {
            get;
            set;
        }
        private void Determine_kind()
        {
            if (wheel_nr == 4)
                type = Type.car;
            if (wheel_nr == 2)
                type = Type.motorcycle;
        }
        public void Say_what_kind()
        {
            Determine_kind();
            if (type==Type.car)
                Console.WriteLine(Name+" is a car!");
            if (type == Type.motorcycle)
                Console.WriteLine(Name+" is a motorcycle!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle() { Name = "GOLF", wheel_nr = 4 };
        
        
            v1.Say_what_kind();
            Vehicle v2 = new Vehicle(2) { Name = "YAMAHA" };
            v2.Say_what_kind();
        }
    }
}
*/
using System;

namespace ClassesCsharp
{
    abstract class Shape
    {
        public abstract double Determine_area();
    }

    class Square : Shape
    {
        double side;

        public Square(int a)
        {
            side = a;
        }

        public override double Determine_area()
        {
            return side * side;
        }
        public double area(int unit)
        {
            return side * side * unit;
        }
    }

    class Circle : Shape
    {
        double rad;

        public Circle(int a)
        {
            rad = a;
        }

        public override double Determine_area()
        {
            return rad * rad * Math.PI;
        }

        public double area(double pi)
        {
            return rad * rad * pi;
        }
    }

    class Program
    {
        readonly int[] t = { 1 };
        static void Main(string[] args)
        {
            Circle c = new Circle(1);
            Console.WriteLine(c.area(Math.PI));
            Square s = new Square(2);
            Console.WriteLine(s.area(1));
            
        }
    }
}
