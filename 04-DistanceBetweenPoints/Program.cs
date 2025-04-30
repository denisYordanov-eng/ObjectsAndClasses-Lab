using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DistanceBetweenPoints
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




            double[] pointsValue1 = Console.ReadLine()
          .Split(' ').Select(double.Parse)
          .ToArray();
            double[] pointsValue2 = Console.ReadLine()
               .Split(' ').Select(double.Parse)
               .ToArray();
            Point p = new Point();
            p.X = pointsValue1[0];
            p.Y = pointsValue1[1];
            double result1 = CalculateDistance1(pointsValue1[0], pointsValue2[0]);

            p.Y = pointsValue2[0];
            p.Y = pointsValue2[0];
            double result2 = CalculateDistance2(pointsValue1[1], pointsValue2[1]);

            double finalResult = CalculateTotalResult(result1, result2);
            Console.WriteLine("{0:F3}",finalResult);
        }

        private static double CalculateTotalResult(double result1, double result2)
        {
            double sideAPow = (double)(Math.Pow(result1, 2));
            double sideBPow = (double)(Math.Pow(result2, 2));

            double totalResult = Math.Sqrt(sideAPow + sideBPow); 
            return totalResult;
        }

        private static double CalculateDistance2(double v1, double v2)
        {
            double result = v1 - v2;
            return result;
        }

        private static double CalculateDistance1(double v1, double v2)
        {
            double result = v1 - v2;
            return result;
        }
    }
}
