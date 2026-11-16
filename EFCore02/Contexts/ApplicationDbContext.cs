using EFCore02;
using EFCore02.Configurations;
using EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore02.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=EFcore01;trusted_connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>(d =>
            {
                d.HasOne(o => o.Organizer)
                .WithOne(o => o.OrganizerProfile)
                .HasForeignKey<OrganizerProfile>(o => o.OrganizerID)
                .IsRequired();
                d.HasKey(o => o.OrganizerProfileID);
            });
            modelBuilder.Entity<Event>(d =>
            {
                d.HasOne(e => e.Organizer)
                 .WithMany(o => o.Events)
                 .HasForeignKey(e => e.OrganizerID)
                 .IsRequired();
                d.HasKey(o => o.EventID);
            });

            modelBuilder.ApplyConfiguration(new BadgeConfiguration());

        }
        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<Badge> Badge { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfile { get; set; }

    }
}
