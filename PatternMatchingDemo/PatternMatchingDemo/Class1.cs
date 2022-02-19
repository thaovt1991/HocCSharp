using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDemo
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(15);
            DisplayArea(circle);
            Rectangle rectangle = new Rectangle(10, 5);
            DisplayArea(rectangle);
            Triangle triangle = new Triangle(10, 5);
            DisplayArea(triangle);
            Console.ReadKey();
        }
        public static void DisplayArea(Shape shape)
        {
            //if (shape is Circle)
            //{
            //    Circle c = (Circle)shape;
            //    Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
            //}
            //else if (shape is Rectangle)
            //{
            //    Rectangle r = (Rectangle)shape;
            //    Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
            //}
            //else if (shape is Triangle)
            //{
            //    Triangle t = (Triangle)shape;
            //    Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
            //}
            //else
            //{
            //    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            //}

            if(shape is Circle)
            {
                Circle c = (Circle)shape;
                Console.WriteLine("Day la hinh tron co ban kinh " + c.Radius + " , pi :" + Shape.PI);
                Console.WriteLine("Dien tich la : " + c.Radius * c.Radius * Shape.PI);
            }
        }
    }
}

