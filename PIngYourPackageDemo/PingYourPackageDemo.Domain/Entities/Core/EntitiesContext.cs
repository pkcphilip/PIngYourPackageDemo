﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackageDemo.Domain.Entities.Core
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("PingYourPackage")
        {
        }

        public IDbSet<ShipmentType> ShipmentTypes { get; set; }

        public IDbSet<Affiliate> Affiliates { get; set; }

        public IDbSet<Shipment> Shipments { get; set; }

        public IDbSet<ShipmentState> ShipmentStates { get; set; }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Role> Roles { get; set; }

        public IDbSet<UserInRole> UserInRoles { get; set; }
    }
}
