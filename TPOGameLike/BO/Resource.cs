using BO.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BO
{
    public class Resource : IDbEntity
    {
        private long? id;
        private String name;
        private int? lastQuantity;
        private DateTime lastUpdate;

        [StringLength(20, MinimumLength = 5)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [IntValidator(0, int.MaxValue)]
        public int? LastQuantity
        {
            get { return lastQuantity; }
            set { lastQuantity = value; }
        }

        [DateValidator]
        public DateTime LastUpdate
        {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }

        public virtual long? Id { get => this.id; set => this.id = value; }
    }
}
