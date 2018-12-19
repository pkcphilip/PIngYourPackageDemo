﻿using PingYourPackageDemo.Domain.Entities.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PingYourPackageDemo.Domain.Entities
{
    public class ShipmentType : IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Shipment> Shipments { get; set; }

        public ShipmentType()
        {
            Shipments = new HashSet<Shipment>();
        }
    }
}
