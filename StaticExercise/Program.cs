using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = TempConverter.FahrenheitToCelsius(68);
            double fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"Celsius: {celsius} degrees");
            Console.WriteLine($"Fahrenheit: {fahrenheit} degrees");
        }
    }
}
