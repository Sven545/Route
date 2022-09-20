using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Route.Models
{
    internal class PointEntity
    {
        public string Name { get; set; }
        public Point Coordinate { get; set; }
       // public IEnumerable<MovingWay> Ways { get; set; }
        public override string ToString()
        {
            return $"{Name} имеет координаты {Coordinate}";
        }
    }
}
