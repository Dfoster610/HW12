using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarLotDB.Models
{
    public class Vehicles
    {

        public virtual int Id { get; set; }

        public virtual int Year { get; set; }

        public virtual string Make { get; set; }

        public virtual string Model { get; set; }

        public virtual int QTY { get; set; }

        public virtual int VehicleId { get; set; }

        public virtual int  FuelTankCapacity { get; set; }

        public virtual string Rating { get; set; }
    }
}