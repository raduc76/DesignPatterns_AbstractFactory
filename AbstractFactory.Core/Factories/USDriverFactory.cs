using AbstractFactory.Core.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Factories
{
    public class USDriverFactory : IDriverFactory
    {
        public IDriver CreateBloodPressureDriver()
        {
            return new BloodPressureOmronDriver();
        }

        public IDriver CreateOximeterDriver()
        {
            return new OximeterWelchAllynDriver();
        }

        public IDriver CreateScaleDriver()
        {
            return new ScaleKernDriver();
        }
    }
}
