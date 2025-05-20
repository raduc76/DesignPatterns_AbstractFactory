using AbstractFactory.Core.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Factories
{
    public interface IDriverFactory
    {
        IDriver CreateBloodPressureDriver();

        IDriver CreateOximeterDriver();

        IDriver CreateScaleDriver();
    }
}
