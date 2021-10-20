using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DaySix_Misc_Projects
{

    class Shape
    {
        public const float PI = 3.14F;
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }

    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }

    class Square : Shape
    {

    }

    internal class PatternMatchingExample
    {
        public static void Calculate(Shape shape)
        {
            switch(shape)
            {
                case Circle circle:
                    Console.WriteLine("Area of Circle : " + nameof(Shape) + " : " + (circle.Radius * circle.Radius * Shape.PI));
                    break;
                case Rectangle rectangle:
                    Console.WriteLine("Area of Rectangle : " + nameof(Shape) + " : " + (rectangle.Length * rectangle.Height));
                    break;
                case Triangle triangle:
                    Console.WriteLine("Area of Traingle : " + nameof(Shape) + " : " + (0.5 * triangle.Base * triangle.Height));
                    break;
                default:
                    Square square = (Square)shape;
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(Shape));
            }
            //----------------------------------OR----------------------------------------
            //if (shape is Circle)
            //{
            //    Circle circle = (Circle)shape;
            //    Console.WriteLine("Area of Circle : " + nameof(Shape) + " : " + (circle.Radius * circle.Radius * Shape.PI));
            //}
            //else if (shape is Rectangle rectangle)
            //{
            //    Console.WriteLine("Area of Rectangle : " + nameof(Shape) + " : " + (rectangle.Length * rectangle.Height));
            //}
            //else if (shape is Triangle triangle)
            //{
            //    Console.WriteLine("Area of Traingle : " + nameof(Shape) + " : " + (0.5 * triangle.Base * triangle.Height));

            //}
            //else
            //{
            //    Square square = (Square)shape;
            //    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(Shape));
            //}
        }

        static void MainMethod(string[] args)
        {
            Circle circle = new Circle(10);
            Calculate(circle);

            Rectangle rectangle = new Rectangle(10, 5);
            Calculate(rectangle);

            Triangle triangle = new Triangle(10, 5);
            Calculate(triangle);

            ////For Testing else block
            //Square square = new Square();
            //Calculate(square);
        }
    }
}
