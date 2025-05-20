using AbstractFactory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Drivers
{
    public class BloodPressureOmronDriver: IDriver
    {
        public IList<Measurement> PerformMeasurement()
        {
            Console.WriteLine("Measurement performed in Blood Pressure Omron Driver [US Approved]");

            // Simulate blood pressure measurement
            return new List<Measurement>
            {
                new Measurement(110, "mmHg"),
                new Measurement(70, "mmHg")
            };
        }
    }
}
