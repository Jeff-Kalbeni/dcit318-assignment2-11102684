using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        interface IMovable
        {
            void Move();
        }

        class Car : IMovable
        {
            public  void Move()
            {
                Console.WriteLine("Car is moving");
            }
        }

        class Bicycle : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Bicycle is moving");
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}
