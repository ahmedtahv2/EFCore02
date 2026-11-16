using EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore02.Configurations
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> b)
        {
            b.HasOne(o => o.Attendee)
                .WithOne(o => o.Badge)
                .HasForeignKey<Badge>(o => o.AttendeeID)
                .IsRequired();
            b.HasKey(o => o.BadgeID);
        }
    }
}
