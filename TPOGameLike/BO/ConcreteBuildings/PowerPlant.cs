using BO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.ConcreteBuildings
{
    public class PowerPlant : ResourceGenerator
    {
        private Func<int?, int?> energyFunc = (int? x) => { return x; };
        private Func<int?, int?> oxygenFunc = (int? x) => { return (200 * (x / 12)) + 20; };
        private Func<int?, int?> steelFunc = (int? x) => { return (1000 * (x / 8)) + 20; };
        private Func<int?, int?> uraniumFunc = (int? x) => { return (1500 * (x / 20)) + 20; };

        public override List<Resource> TotalCost
        {
            get
            {
                List<Resource> ResourceRes = new List<Resource>();
                // Energy
                Resource energy = new Resource() { Name = ResourcesConstants.RESOURCE_ENERGY, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(energyFunc, this.Level) };
                ResourceRes.Add(energy);

                // Oxygen
                Resource oxygen = new Resource() { Name = ResourcesConstants.RESOURCE_OXYGEN, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(oxygenFunc, this.Level) };
                ResourceRes.Add(oxygen);

                // Steel
                Resource steel = new Resource() { Name = ResourcesConstants.RESOURCE_STEEL, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(steelFunc, this.Level) };
                ResourceRes.Add(steel);

                // Uranium
                Resource uranium = new Resource() { Name = ResourcesConstants.RESOURCE_URANIUM, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(uraniumFunc, this.Level) };
                ResourceRes.Add(uranium);

                return ResourceRes;
            }
        }

        public override List<Resource> NextCost
        {
            get
            {
                List<Resource> ResourceRes = new List<Resource>();
                // Energy
                Resource energy = new Resource() { Name = ResourcesConstants.RESOURCE_ENERGY, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(energyFunc, this.Level +1) };
                ResourceRes.Add(energy);

                // Oxygen
                Resource oxygen = new Resource() { Name = ResourcesConstants.RESOURCE_OXYGEN, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(oxygenFunc, this.Level +1 ) };
                ResourceRes.Add(oxygen);

                // Steel
                Resource steel = new Resource() { Name = ResourcesConstants.RESOURCE_STEEL, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(steelFunc, this.Level +1) };
                ResourceRes.Add(steel);

                // Uranium
                Resource uranium = new Resource() { Name = ResourcesConstants.RESOURCE_URANIUM, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(uraniumFunc, this.Level +1) };
                ResourceRes.Add(uranium);

                return ResourceRes;

            }
        }

        public override List<Resource> ResourceBySecond
        {
            get
            {
                List<Resource> res = new List<Resource>();
                Resource oxygen = new Resource() { Name = ResourcesConstants.RESOURCE_OXYGEN, LastUpdate = DateTime.Now, LastQuantity = (20 * (this.Level / 2)) + 5 };
                res.Add(oxygen);
                return res;
            }
        }
    }
}
