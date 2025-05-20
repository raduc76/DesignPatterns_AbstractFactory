using AbstractFactory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Drivers
{
    public class ScaleKernDriver: IDriver
    {
        public IList<Measurement> PerformMeasurement()
        {
            Console.WriteLine("Measurement performed in Scale Kern Driver [EU & US Approved]");

            // Simulate scale measurement
            return new List<Measurement>
            {
                new Measurement(70, "kg"),
            };
        }
    }
}
