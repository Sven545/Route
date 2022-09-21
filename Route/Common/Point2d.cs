using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.Common
{
    public struct Point2d
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point2d(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
