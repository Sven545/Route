using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.Models
{
    internal class MovingWay
    {
        public string Name { get; set; }
        public Road Road { get; set; }
        public Transport Transport { get; set; }
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
                return Transport.AverageSpeed*Road.LengthInKilometers;
            }
        }
        public override string ToString()
        {
            return  $"Способ добраться из {Road.StartPoint.Name} в {Road.EndPoint.Name} стоимостью {MovingCostInRuble} руб. с помощью {Transport.Name} за {MovingTimeInHours} часов";
        }
    }
}
