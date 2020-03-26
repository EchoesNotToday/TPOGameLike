using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.ConcreteBuildings
{
    public class OxygenGenerator : ResourceGenerator
    {
        private Func<int?, int?> energyFunc = (int? x) => { return x; };
        private Func<int?, int?> oxygenFunc = (int? x) => { return (200 * (x / 12)) + 20; };
        private Func<int?, int?> steelFunc = (int? x) => { return (1000 * (x / 8)) + 20; };
        private Func<int?, int?> uraniumFunc = (int? x) => { return (1500 * (x / 20)) + 20; };
    }
}
