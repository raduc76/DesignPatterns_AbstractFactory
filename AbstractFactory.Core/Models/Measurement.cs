using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Models
{
    public class Measurement(decimal value, string unit)
    {
        public decimal Value = value;

        public string Unit = unit;
    }
}
