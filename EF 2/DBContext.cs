using EF_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Organizer> organizers { get; set; }
        public DbSet<OrganizerProfile> organizerProfiles { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<Attendee> attendees { get; set; }
        public DbSet<Badge> badges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(
                new OrganizerProfileConfiguration());
            

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Organizer)
                .WithMany(o => o.Events)
                .HasForeignKey(e => e.OrganizerId);

            
            modelBuilder.Entity<Badge>()
                .HasOne(b => b.Attendee)
                .WithOne(a => a.Badge)
                .HasForeignKey<Badge>(b => b.AttendeeId);

            
            modelBuilder.Entity<Badge>()
                .HasIndex(b => b.BadgeNmber)
                .IsUnique();

            modelBuilder.Entity<Badge>()
                .ToTable(t => t.HasCheckConstraint(
                    "CK_Badge_Tier",
                    "[Tier] IN ('Standard', 'VIP')"));
        
        }

    }
}
