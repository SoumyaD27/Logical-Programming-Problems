﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemptConver
{
    internal class temp
    {
        public static float F, C, Fahrenheit, Celsius;
        public static void temperaturConversionToFahrenheit()
        {
            Fahrenheit = (C * 9 / 5) + 32;
            Console.Write("Celsius to Fahrenheit: " + Fahrenheit);
        }
        public static void temperaturConversionToCelsius()
        {
            Celsius = (F - 32) * 5 / 9;
            Console.Write("Fahrenheit to Celsius : " + Celsius);
        }
    }
}
