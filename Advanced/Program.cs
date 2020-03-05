using System;

namespace Advanced
{
   /* public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
    public class Circle
    {
        public double Radius { get; set; }
    }

    public class AreaCalculator
    {
        public static double Area(Rectangle[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }

            return area;
        }
    }
    public class AreaCalculator
    {
        public static double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                if (shape is Circle)
                {
                    
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }*/
   #region solved-ocp
     
    public abstract class Shape
    {
    public abstract double Area();
    }
public class Rectangle : Shape
    {
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area()
    {
        return Width*Height;
    }
    }
    public class Circle : Shape
    {
    public double Radius { get; set; }
    public override double Area()
       {
        return Radius*Radius*Math.PI;
        }
    }

    public class AreaCalculator
    {
        public static double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
    
    #endregion solved-ocp
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle[] myRect = new Rectangle[2];
             myRect[0] = new Rectangle() { Width = 2, Height = 3};
             myRect[1] = new Rectangle() { Width = 2, Height = 3 };
             Circle[] myCirc = new Circle[2];
             myCirc[0] = new Circle() { Radius=3 };
             myCirc[1] = new Circle () { Radius= 2 };
             Console.WriteLine(AreaCalculator.Area(myCirc));*/
           Shape[] myShape = new Shape[4];
            myShape[0] = new Rectangle() { Width = 2, Height = 3 };
            myShape[1] = new Rectangle() { Width = 2, Height = 3 };           
            myShape[2] = new Circle() { Radius = 3 };
            myShape[3] = new Circle() { Radius = 2 };
            Console.WriteLine(AreaCalculator.Area(myShape));
        }
    }
}
