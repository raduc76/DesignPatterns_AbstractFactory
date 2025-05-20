using AbstractFactory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Drivers
{
    public class OximeterWelchAllynDriver: IDriver
    {
        public IList<Measurement> PerformMeasurement()
        {
            Console.WriteLine("Measurement performed in Oximeter Welch Allyn Driver [US Approved]");

            // Simulate oximeter measurement
            return new List<Measurement>
            {
                new Measurement(97, "%"),
                new Measurement(72, "bpm")
            };
        }
    }
}
