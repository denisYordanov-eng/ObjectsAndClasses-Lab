using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DistanceBetweenPointsDiffrentWay
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        static void Main(string[] args)
        {
            Point p1 = new Point();
           p1 =  ReadInput();
            Point p2 = new Point();
            p2 = ReadInput();

          var result =  CalculateDistanceBetweenPoint(p1, p2);
            Console.WriteLine("{0:f3}", result);
        }
        static double CalculateDistanceBetweenPoint(Point p1, Point p2)
        {
            double diffX = p2.X - p1.X;
            double diffY = p2.Y - p1.Y;
            return Math.Sqrt((diffX * diffX) + (diffY * diffY));
        }

        static Point ReadInput()
        {
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(a => double.Parse(a))
                .ToArray();

            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];
            return point;
        }
    }
}
