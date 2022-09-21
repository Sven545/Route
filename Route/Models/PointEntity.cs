using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Common;

namespace Route.Models
{
    public class PointEntity
    {
        public string Name { get; private set; }
        public Point2d Coordinate { get; private set; }
        public PointEntity(string name, Point2d coordinate)
        {
            Name = name;
            Coordinate = coordinate;
        }

        public override string ToString()
        {
            return $"{Name} имеет координаты {Coordinate}";
        }
    }
}
