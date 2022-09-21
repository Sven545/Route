using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.Models
{
    public class Transport
    {
        public string Name { get; set; }


        /// <summary>
        /// Средняя скорость км/ч
        /// </summary>
        public double AverageSpeed { get; set; }


        /// <summary>
        /// Средняя цена километра пути
        /// </summary>
        public double AverageKilometerPrice { get; set; }

        public override string ToString()
        {
            return $"{Name} имеет среднюю скорость {AverageSpeed} км/ч и среднюю цену за километр {AverageKilometerPrice}";
        }
    }
}
