﻿using BO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.ConcreteBuildings
{
    public class UraniumGenerator : ResourceGenerator
    {
        private Func<int?, int?> energyFunc = (int? x) => { return x; };
        private Func<int?, int?> oxygenFunc = (int? x) => { return (200 * (x / 2)) + 20; };
        private Func<int?, int?> steelFunc = (int? x) => { return (100 * (x / 3)) + 20; };
        private Func<int?, int?> uraniumFunc = (int? x) => { return 7 * int.Parse(Math.Pow(x.Value, 3).ToString()) + (200 * (x / 12)) + 20; };

        public override List<Resource> TotalCost
        {
            get
            {
                List<Resource> res = new List<Resource>();
                // Energy
                Resource energy = new Resource() { Name = ResourcesConstants.RESOURCE_ENERGY, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(energyFunc, this.Level) };
                res.Add(energy);

                // Oxygen
                Resource oxygen = new Resource() { Name = ResourcesConstants.RESOURCE_OXYGEN, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(oxygenFunc, this.Level) };
                res.Add(oxygen);

                // Steel
                Resource steel = new Resource() { Name = ResourcesConstants.RESOURCE_STEEL, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(steelFunc, this.Level) };
                res.Add(steel);

                // Uranium
                Resource uranium = new Resource() { Name = ResourcesConstants.RESOURCE_URANIUM, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(uraniumFunc, this.Level) };
                res.Add(uranium);

                return res;
            }
        }
        public override List<Resource> NextCost
        {
            get
            {
                List<Resource> res = new List<Resource>();
                // Energy
                Resource energy = new Resource() { Name = ResourcesConstants.RESOURCE_ENERGY, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(energyFunc, this.Level +1) };
                res.Add(energy);

                // Oxygen
                Resource oxygen = new Resource() { Name = ResourcesConstants.RESOURCE_OXYGEN, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(oxygenFunc, this.Level +1) };
                res.Add(oxygen);

                // Steel
                Resource steel = new Resource() { Name = ResourcesConstants.RESOURCE_STEEL, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(steelFunc, this.Level +1) };
                res.Add(steel);

                // Uranium
                Resource uranium = new Resource() { Name = ResourcesConstants.RESOURCE_URANIUM, LastUpdate = DateTime.Now, LastQuantity = ResourcesMathUtil.FactorialMath(uraniumFunc, this.Level +1) };
                res.Add(uranium);

                return res;
            }
        }
        public override List<Resource> ResourceBySecond
        {
            get
            {
                List<Resource> res = new List<Resource>();
                Resource uranium = new Resource() { Name = ResourcesConstants.RESOURCE_URANIUM, LastUpdate = DateTime.Now, LastQuantity = int.Parse((7 * Math.Pow(this.Level.Value, 3) + 2).ToString()) };
                res.Add(uranium);
                return res;
            }
        }
    }
}
