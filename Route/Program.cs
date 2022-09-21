using Route.Models;
using Route.Common;

namespace Route
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<PointEntity> points = new List<PointEntity>();
            List<Transport> transports = new List<Transport>();

            PointEntity pointA = new PointEntity("A", new Point2d(0, 0));
            PointEntity pointB = new PointEntity("B", new Point2d(5, 0));

            PointEntity pointM1 = new PointEntity("M1", new Point2d(0, 2));
            PointEntity pointM2 = new PointEntity("M2", new Point2d(2, -1));
            PointEntity pointM3 = new PointEntity("M3", new Point2d(4, 1));

            PointEntity pointO1 = new PointEntity("O1", new Point2d(1, -1));
            PointEntity pointO2 = new PointEntity("O2", new Point2d(3, -1));

            points.Add(pointA);
            points.Add(pointB);
            points.Add(pointM1);
            points.Add(pointM2);
            points.Add(pointM3);
            points.Add(pointO1);
            points.Add(pointO2);

            Transport foot = new Transport() { Name = "Пешком", AverageSpeed = 5, AverageKilometerPrice = 0 };
            Transport personalCar = new Transport() { Name = "Личный автомобиль", AverageSpeed = 50, AverageKilometerPrice = 0 };
            Transport taxi = new Transport() { Name = "Такси", AverageSpeed = 50, AverageKilometerPrice = 60 };
            Transport bus = new Transport() { Name = "Автобус", AverageSpeed = 40, AverageKilometerPrice = 30 };
            Transport underground = new Transport() { Name = "Метро", AverageSpeed = 60, AverageKilometerPrice = 20 };

            transports.Add(foot);
            transports.Add(personalCar);
            transports.Add(taxi);
            transports.Add(bus);
            transports.Add(underground);

            var wayManager = new WayManager();
            var roads = wayManager.GetRoads(points);
            var ways = wayManager.GetWays(roads, transports);

            foreach (var way in ways)
            {
                Console.WriteLine(way);
            }


        }
    }
}