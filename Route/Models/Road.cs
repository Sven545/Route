using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.Models
{
    public class Road
    {
        public PointEntity StartPoint { get; private set; }
        public PointEntity EndPoint { get; private set; }
        public Road(PointEntity startPoint, PointEntity endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public double LengthInKilometers
        {
            get
            {
                return Math.Sqrt(Math.Pow(EndPoint.Coordinate.X - StartPoint.Coordinate.X, 2) + Math.Pow(EndPoint.Coordinate.Y - StartPoint.Coordinate.Y, 2));
            }
        }
        //public MovingWay MovingWay { get; set; }

        public override string ToString()
        {
            return $"Маршрут из точки {StartPoint.Name} в точку {EndPoint.Name} расстоянием {LengthInKilometers}";
        }
    }
}
