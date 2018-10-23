using System;

namespace Demo.Debug.Lib
{
    public static class GreatCircleDistance
    {
        public static double CalculateGreaterCircleDistance(City start, City end)
        {
            var radius = 6372.8;

            var dLat = ToRadians(end.Latitude - start.Latitude);
            var dLon = ToRadians(end.Longitude - start.Longitude);

            start.Latitude = ToRadians(start.Latitude);
            end.Latitude = ToRadians(end.Latitude);

            return radius * 2 * Math.Asin(Math.Sqrt(Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(start.Latitude) * Math.Cos(end.Latitude)));
        }

        private static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0D;
        }
    }

    public class City
    {
        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
