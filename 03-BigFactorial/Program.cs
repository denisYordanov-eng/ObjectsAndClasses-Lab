﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03_BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
