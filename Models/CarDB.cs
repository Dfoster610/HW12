using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarLotDB.Models
{
    public class CarDB : DbContext
    {
        public CarDB() : base ("name=CarDB")
        {

        }

        public DbSet<Vehicles> Vehicles { get; set; }

        public DbSet<VehicleTypes> VehicleTypes { get; set; }

    }
}