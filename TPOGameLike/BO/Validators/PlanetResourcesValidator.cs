using BO.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Validators
{
    public class PlanetResourcesValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = true;
            List<Resource> resources = value as List<Resource>;
            if (resources.Count() != 4)
            {
                result = false;
            }
            bool energyBool = false;
            bool oxygenBool = false;
            bool steelBool = false;
            bool uraniumBool = false;

            resources.ForEach((x) =>
            {
                if (ResourcesConstants.RESOURCE_ENERGY == x.Name)
                {
                    energyBool = true;
                }
                else if (ResourcesConstants.RESOURCE_OXYGEN == x.Name)
                {
                    oxygenBool = true;
                }
                else if (ResourcesConstants.RESOURCE_STEEL == x.Name)
                {
                    steelBool = true;
                }
                else if (ResourcesConstants.RESOURCE_URANIUM == x.Name)
                {
                    uraniumBool = true;
                }
            });

            if (!(energyBool && oxygenBool && steelBool && uraniumBool))
            {
                result = false;
            }
            return result;
        }
    }
}
