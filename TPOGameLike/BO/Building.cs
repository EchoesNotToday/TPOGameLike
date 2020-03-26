using BO.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BO
{
    public abstract class Building : IDbEntity
    {


        private long? id;
        private String name;
        private int? level;


        [StringLength(20, MinimumLength = 5)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [IntValidator(0, int.MaxValue)]
        public virtual int? Level
        {
            get { return level; }
            set { level = value; }
        }

        [NotMapped]
        public virtual int? CellNb
        {
            get { return level; }
        }

        [NotMapped]
        public virtual List<Resource> TotalCost
        {
            get { return new List<Resource>(); }
        }

        [NotMapped]
        public virtual List<Resource> NextCost
        {
            get { return new List<Resource>(); }
        }

        public virtual long? Id { get => this.id; set => this.id = value; }

    }
}
