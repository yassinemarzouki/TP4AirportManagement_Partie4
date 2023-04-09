﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int Id { get; set; }
        [ForeignKey("Plane")]
        public int planeId { get; set; }

        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightID { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        public plane Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public string Airline { get; set; }
        public override string ToString()
        {
            return this.FlightID + " " + this.Destination + " " + this.Departure+" "+this.EstimatedDuration;
        }
    }
}

