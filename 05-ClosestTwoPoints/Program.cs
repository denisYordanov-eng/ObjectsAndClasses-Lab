using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _05_ClosestTwoPoints
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
            Point[] points = ReadPoints();

            Point[] closestPoints = CalulateClosestPoints(points);

            PrintDistance(closestPoints);
            Print(closestPoints[0]);
            Print(closestPoints[1]);
        }

        private static Point[] CalulateClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1;  p2 < points.Length;  p2++)
                {
                    double distance = CalculateDistanceBetweenPoint(points[p1], points[p2]);

                    if(distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            }
            return closestTwoPoints;
        }

        static void PrintDistance(Point[] points)
        {
            var distance = CalculateDistanceBetweenPoint(points[0], points[1]);
            Console.WriteLine("{0:F3}",distance);
        }

         static void Print(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

         static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadInput();
            }
            return points;
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
