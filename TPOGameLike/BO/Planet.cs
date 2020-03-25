using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BO
{
    public class Planet : IDbEntity
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int? caseNb { get; set; }

        [NotMapped]
        public virtual List<Building> Buildings { get; set; }
        public virtual List<Resource> Resources { get; set; }

        public Planet()
        {
            this.Buildings = new List<Building>();
            this.Resources = new List<Resource>();
        }
    }
}
