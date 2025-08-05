using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Abstract_Class
{
    internal class Program
    {
        abstract class Shape
        {
            public abstract void GetArea();
        }

        class Circle : Shape
        {
            public override void GetArea()
            {
                double area = 2 * Math.PI * (5 * 5);
                Console.WriteLine("The area of the circle is: " + area);
            }
        }

        class Rectangle : Shape
        {
            public override void GetArea()
            {
                double area = 20 * 10;
                Console.WriteLine("The area of the rectangle is: " + area);
            }
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rect = new Rectangle();

            circle.GetArea();
            rect.GetArea();
        }
    }
}
