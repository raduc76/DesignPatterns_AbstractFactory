using AbstractFactory.Core.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Factories
{
    public class EUDriverFactory: IDriverFactory
    {
        public IDriver CreateBloodPressureDriver()
        {
            return new BloodPressureMedlabDriver();
        }

        public IDriver CreateOximeterDriver()
        {
            return new OximeterMedlabDriver();
        }

        public IDriver CreateScaleDriver()
        {
            return new ScaleKernDriver();
        }
    }
}
