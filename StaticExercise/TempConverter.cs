using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
         public static double FahrenheitToCelsius(double f)
        {
            double Celsius = (f - 32) * 5 / 9;

            return Celsius;
        }
        public static double CelsiusToFahrenheit(double c)
        {
            double Fahrenheit = (c * 9) / 5 + 32;

            return Fahrenheit;
        }
    }
}
