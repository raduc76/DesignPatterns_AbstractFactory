using AbstractFactory.Core.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Factories
{
    public class EUDriverFactoryWithDI : IDriverFactory
    {
        private readonly IEnumerable<IDriver> drivers;

        public EUDriverFactoryWithDI(IEnumerable<IDriver> drivers)
        {
            this.drivers = drivers;
        }

        public IDriver CreateBloodPressureDriver()
        {
            return drivers.FirstOrDefault(d => d.GetType() == typeof(BloodPressureMedlabDriver))!;
        }

        public IDriver CreateOximeterDriver()
        {
            return drivers.FirstOrDefault(d => d.GetType() == typeof(OximeterMedlabDriver))!;
        }

        public IDriver CreateScaleDriver()
        {
            return drivers.FirstOrDefault(d => d.GetType() == typeof(ScaleKernDriver))!;
        }
    }
}
