using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    public abstract class ResourceGenerator : Building
    {
        private List<Resource> resourceBySecond;
        public virtual List<Resource> ResourceBySecond
        {
            get { return resourceBySecond; }
        }
        public ResourceGenerator()
        {
            this.resourceBySecond = new List<Resource>();
        }
    }
}
