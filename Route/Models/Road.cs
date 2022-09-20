using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.Models
{
    internal class Road
    {
        public PointEntity StartPoint { get; set; }
        public PointEntity EndPoint { get; set; }

        public double LengthInKilometers { get; set; }
        //public MovingWay MovingWay { get; set; }

        public override string ToString()
        {
            return $"Маршрут из точки {StartPoint.Name} в точку {EndPoint.Name} расстоянием {LengthInKilometers}";
        }
    }
}
