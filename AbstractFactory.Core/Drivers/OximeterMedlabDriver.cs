using AbstractFactory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Drivers
{
    public class OximeterMedlabDriver: IDriver
    {
        public IList<Measurement> PerformMeasurement()
        {
            Console.WriteLine("Measurement performed in Oximeter Medlab Driver [EU Approved]");

            // Simulate oximeter measurement
            return new List<Measurement>
            {
                new Measurement(98, "%"),
                new Measurement(75, "bpm")
            };
        }
    }
}
