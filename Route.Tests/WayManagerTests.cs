using Route.Common;
using Route.Models;

namespace Route.Tests
{
    public class WayManagerTests
    {
        [Fact]
        public void GetRoads_Input2Points_Return2Roads()
        {
            var pointA = new PointEntity("point A", new Point2d(0, 0));
            var pointB = new PointEntity("point B", new Point2d(0, 5));

            var points = new List<PointEntity>() { pointA, pointB };
            var wayManager = new WayManager();
            var result = wayManager.GetRoads(points).ToList();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetRoads_Input3Points_Return6Roads()
        {
            var pointA = new PointEntity("point A", new Point2d(0, 0));
            var pointB = new PointEntity("point B", new Point2d(0, 5));
            var pointC = new PointEntity("point C", new Point2d(0, 10));

            var points = new List<PointEntity>() { pointA, pointB, pointC };
            var wayManager = new WayManager();
            var result = wayManager.GetRoads(points).ToList();

            Assert.Equal(6, result.Count);
        }
        [Fact]
        public void GetRoads_Input4Points_Return12Roads()
        {
            var pointA = new PointEntity("point A", new Point2d(0, 0));
            var pointB = new PointEntity("point B", new Point2d(0, 5));
            var pointC = new PointEntity("point C", new Point2d(0, 10));
            var pointD = new PointEntity("point D", new Point2d(0, 20));

            var points = new List<PointEntity>() { pointA, pointB, pointC, pointD };
            var wayManager = new WayManager();
            var result = wayManager.GetRoads(points).ToList();

            Assert.Equal(12, result.Count);
        }

        [Fact]
        public void GetRoads_Input5Points_Return20Roads()
        {
            var pointA = new PointEntity("point A", new Point2d(0, 0));
            var pointB = new PointEntity("point B", new Point2d(0, 5));
            var pointC = new PointEntity("point C", new Point2d(0, 10));
            var pointD = new PointEntity("point D", new Point2d(0, 20));
            var pointE = new PointEntity("point E", new Point2d(0, 30));

            var points = new List<PointEntity>() { pointA, pointB, pointC, pointD, pointE };
            var wayManager = new WayManager();
            var result = wayManager.GetRoads(points).ToList();

            Assert.Equal(20, result.Count);
        }

        [Fact]
        public void GetWays_Input2Transports_6Roads_Return12Ways()
        {
            var pointA = new PointEntity("point A", new Point2d(0, 0));
            var pointB = new PointEntity("point B", new Point2d(0, 5));
            var pointC = new PointEntity("point C", new Point2d(0, 10));

            var roadA_B = new Road(pointA, pointB);
            var roadB_A = new Road(pointB, pointA);

            var roadA_C = new Road(pointA, pointC);
            var roadC_A = new Road(pointC, pointA);

            var roadB_C = new Road(pointB, pointC);
            var roadC_B = new Road(pointC, pointB);

            var transport1 = new Transport();
            var transport2 = new Transport();

            var roads = new List<Road>();
            roads.Add(roadA_B);
            roads.Add(roadB_A);
            roads.Add(roadA_C);
            roads.Add(roadC_A);
            roads.Add(roadB_C);
            roads.Add(roadC_B);

            var transports=new List<Transport>() { transport1,transport2};

            var wayManager = new WayManager();
            var result = wayManager.GetWays(roads,transports).ToList();

            Assert.Equal(12, result.Count);
        }
    }
}