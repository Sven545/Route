using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Models;
using System.Linq;

namespace Route.Common
{
    public class WayManager
    {


        public IEnumerable<Road> GetRoads(IEnumerable<PointEntity> points)
        {
            List<Road> roads = new List<Road>();

            foreach (var startPoint in points)
            {
                foreach (var endPoint in points)
                {
                    if (startPoint != endPoint)
                    {
                        roads.Add(new Road(startPoint, endPoint));
                    }
                }
            }

            return roads;
        }
        public IEnumerable<MovingWay> GetWays(IEnumerable<Road> roads, IEnumerable<Transport>transports)
        {
            List<MovingWay> ways = new List<MovingWay>();

            foreach (var transport in transports)
            {
                foreach (var road in roads)
                {
                    ways.Add(new MovingWay(road, transport));
                }
            }
            return ways;
        }
    }
}
