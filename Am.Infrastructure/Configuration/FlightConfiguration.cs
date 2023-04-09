﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Infrastructure.Configuration
{
    internal class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(f => f.Passengers)
                .WithMany(p=>p.Flights)
                .UsingEntity(x=>x.ToTable("MyReservation"));
            builder.HasOne(f => f.Plane).
                WithMany(p => p.Flights).
                HasForeignKey(f => f.planeId).
                OnDelete(DeleteBehavior.ClientSetNull);
                  

        }
    }
}
