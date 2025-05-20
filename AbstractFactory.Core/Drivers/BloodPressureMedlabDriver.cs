using AbstractFactory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Drivers
{
    public class BloodPressureMedlabDriver: IDriver
    {
        public IList<Measurement> PerformMeasurement()
        {
            Console.WriteLine("Measurement performed in Blood Pressure Medlab Driver [EU Approved]");

            // Simulate blood pressure measurement
            return new List<Measurement>
            {
                new Measurement(120, "mmHg"),
                new Measurement(80, "mmHg")
            };
        }
    }
}
