using System;

namespace Temperatures {
    class Program {
        static void Main(string[] args) {
            var temps = new Temperatures(31.2, 25.5, 24.0, 34.3, 19.9, 23.8, 26.1);

            Console.WriteLine("Weekly Temperatures:\n");
            Console.WriteLine(temps);

            Console.WriteLine($"\nAverage without lowest temperature is {temps.GetAverageWithoutLowest():f1}");
        }
    }
}
