﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Inches: ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;

            
            Console.WriteLine("{0:F2}", centimeters);
        }
    }
}
