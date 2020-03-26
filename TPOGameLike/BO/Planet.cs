using BO.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Text;

namespace BO
{
    public class Planet : IDbEntity
    {
        private long? id;
        private String name;
        private int? caseNb;
        private List<Building> buildings;
        private List<Resource> resources;
        public virtual long? Id { get => this.id; set => this.id = value; }

        [StringLength(20, MinimumLength = 5)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [IntValidator(0, int.MaxValue)]
        public int? CaseNb 
        {
            get { return caseNb; }
            set { caseNb = value; }
        }

        [NotMapped]
        public virtual List<Building> Buildings {
            get { return buildings; }
            set { buildings = value; }
        }
        [PlanetResourcesValidator]
        public virtual List<Resource> Resources { 
            get { return resources; }
            set { resources = value; }
        }

        public Planet()
        {
            this.Buildings = new List<Building>();
            this.Resources = new List<Resource>();
        }
    }
}
