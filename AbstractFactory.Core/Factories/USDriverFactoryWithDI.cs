using AbstractFactory.Core.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Factories
{
    public class USDriverFactoryWithDI: IDriverFactory
    {
        private readonly IEnumerable<IDriver> drivers;

        public USDriverFactoryWithDI(IEnumerable<IDriver> drivers)
        {
            this.drivers = drivers;
        }

        public IDriver CreateBloodPressureDriver()
        {
            return drivers.FirstOrDefault(d => d.GetType() == typeof(BloodPressureOmronDriver))!;
        }

        public IDriver CreateOximeterDriver()
        {
            return drivers.FirstOrDefault(d => d.GetType() == typeof(OximeterWelchAllynDriver))!;
        }

        public IDriver CreateScaleDriver()
        {
            return drivers.FirstOrDefault(d => d.GetType() == typeof(ScaleKernDriver))!;
        }
    }
}
