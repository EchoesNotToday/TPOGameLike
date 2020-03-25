using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Resource : IDbEntity
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int LastQuantity { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
