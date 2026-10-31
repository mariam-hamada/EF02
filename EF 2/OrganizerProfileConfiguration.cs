using EF_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2
{
    internal class OrganizerProfileConfiguration : IEntityTypeConfiguration<Models.OrganizerProfile>
    {
        public void Configure(
            EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(op => op.OrganizerProfileId);

            builder.Property(op => op.Biography)
                   .HasMaxLength(500);

            builder.Property(op => op.Website)
                   .HasMaxLength(250);

            builder.HasOne(op => op.Organizer)
                   .WithOne(o => o.OrganizerProfile)
                   .HasForeignKey<OrganizerProfile>(
                       op => op.OrganizerId);
        }
    }
}
