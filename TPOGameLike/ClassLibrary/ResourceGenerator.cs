using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class ResourceGenerator : Building
    {
        public List<Resource> ResourceBySecond()
        {
            return new List<Resource>();
        }
    }
}
