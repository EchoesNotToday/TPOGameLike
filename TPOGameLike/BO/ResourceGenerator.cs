using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    public abstract class ResourceGenerator : Building
    {
        private List<Resource> resourceBySecond;
        public List<Resource> ResourceBySecond()
        {
            return new List<Resource>();
        }
        public ResourceGenerator()
        {
            this.resourceBySecond = new List<Resource>();
        }
    }
}
