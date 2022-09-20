using Route.Models;
using System.Drawing;

namespace Route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointEntity pointA = new PointEntity() { Name = "A", Coordinate = new Point(0, 0) };
            PointEntity pointB = new PointEntity() { Name = "B", Coordinate = new Point(5, 0) };

            PointEntity pointM1 = new PointEntity() { Name = "M1", Coordinate = new Point(0, 2) };
            PointEntity pointM2 = new PointEntity() { Name = "M2", Coordinate = new Point(2, -1) };
            PointEntity pointM3 = new PointEntity() { Name = "M3", Coordinate = new Point(4, 1) };

            PointEntity pointO1 = new PointEntity() { Name = "O1", Coordinate = new Point(1, -1) };
            PointEntity pointO2 = new PointEntity() { Name = "O2", Coordinate = new Point(3, -1) };

            Transport foot = new Transport() { Name = "Пешком", AverageSpeed = 5, AverageKilometerPrice = 0 };
            Transport personalCar = new Transport() { Name = "Личный автомобиль", AverageSpeed = 50, AverageKilometerPrice = 0 };
            Transport taxi = new Transport() { Name = "Такси", AverageSpeed = 50, AverageKilometerPrice = 60 };
            Transport bus = new Transport() { Name = "Автобус", AverageSpeed = 40, AverageKilometerPrice = 30 };
            Transport underground = new Transport() { Name = "Метро", AverageSpeed = 60, AverageKilometerPrice = 20 };

            Road roadA_B = new Road() { StartPoint = pointA, EndPoint = pointB, LengthInKilometers = 10 };
            Road roadB_A = new Road() { StartPoint = pointB, EndPoint = pointA, LengthInKilometers = 10 };

            Road roadA_M1 = new Road() { StartPoint = pointA, EndPoint = pointM1, LengthInKilometers = 2 };
            Road roadM1_A = new Road() { StartPoint = pointM1, EndPoint = pointA, LengthInKilometers = 2 };
            Road roadA_M2 = new Road() { StartPoint = pointA, EndPoint = pointM2, LengthInKilometers = 4 };
            Road roadM2_A = new Road() { StartPoint = pointM2, EndPoint = pointA, LengthInKilometers = 4 };
            Road roadA_M3 = new Road() { StartPoint = pointA, EndPoint = pointM3, LengthInKilometers = 6 };
            Road roadM3_A = new Road() { StartPoint = pointM3, EndPoint = pointA, LengthInKilometers = 6 };


            Road roadA_O1 = new Road() { StartPoint = pointA, EndPoint = pointO1, LengthInKilometers = 1 };
            Road roadO1_A = new Road() { StartPoint = pointO1, EndPoint = pointA, LengthInKilometers = 1 };
            Road roadA_O2 = new Road() { StartPoint = pointA, EndPoint = pointO2, LengthInKilometers = 7 };
            Road roadO2_A = new Road() { StartPoint = pointO2, EndPoint = pointA, LengthInKilometers = 7 };


        }
    }
}