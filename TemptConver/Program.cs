using System;
namespace TempConver
{
            Console.Write("Enter value for C: ");
            temperatureConversion.C=Convert.ToInt32(Console.ReadLine());
            temperatureConversion.temperaturConversionToFahrenheit();

            Console.Write("Enter value for F: ");
            temperatureConversion.F = Convert.ToInt32(Console.ReadLine());
            temperatureConversion.temperaturConversionToCelsius();
 }
