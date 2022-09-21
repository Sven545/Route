using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.Models
{
    public class MovingWay
    {
        public Road Road { get; private set; }
        public Transport Transport { get; private set; }
        public MovingWay(Road road, Transport transport)
        {
            Road = road;
            Transport = transport;
        }

        public double MovingCostInRuble
        {
            get
            {
                return Transport.AverageKilometerPrice * Road.LengthInKilometers;
            }
        }
        public double MovingTimeInHours
        {
            get
            {
                return Road.LengthInKilometers / Transport.AverageSpeed;
            }
        }
        public double MovingTimeInMinutes
        {
            get
            {
                return MovingTimeInHours*60;
            }
        }
        public override string ToString()
        {
            return $"{Road.StartPoint.Name} ---> {Road.EndPoint.Name}. " +
                $"Цена: {Math.Round(MovingCostInRuble, 3)} р. " +
                $"Способ: {Transport.Name}." +
                $" Расстояние: {Math.Round(Road.LengthInKilometers, 3)} км." +
                $" Время: {Math.Round(MovingTimeInMinutes, 3)} мин";
        }
    }
}
