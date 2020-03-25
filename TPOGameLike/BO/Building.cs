using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    public abstract class Building : IDbEntity
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public abstract int CellNb();
        public List<Resource> TotalCost()
        {
            return new List<Resource>();
        }
        public List<Resource> NextCost()
        {
            return new List<Resource>();
        }
    }
}
