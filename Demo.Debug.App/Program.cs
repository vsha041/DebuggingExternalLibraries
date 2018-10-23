using System;
using Demo.Debug.Lib;

namespace Demo.Debug.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            City auckland = new City
            {
                Name = "Auckland",
                Latitude = -36.84D,
                Longitude = 174.76D
            };

            City london = new City
            {
                Name = "London",
                Latitude = 39.89D,
                Longitude = -83.44D
            };

            // distance between 2 points on a sphere
            var distance = GreatCircleDistance.CalculateGreaterCircleDistance(auckland, london);
            Console.WriteLine($"The surface distance between cities {auckland.Name} and {london.Name} is:" + $" {distance}" + "Kms.");
        }
    }
}
