using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Configurations
{
    public class PerformerConfiguration : IEntityTypeConfiguration<Performer>
    {
        public void Configure(EntityTypeBuilder<Performer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(fn => fn.FirstName)
                .HasMaxLength(20)
                .IsRequired(true);
            builder.Property(ln => ln.LastName)
               .HasMaxLength(20)
               .IsRequired(true);
            builder.Property(a => a.Age)
                .IsRequired(true);
            builder.Property(nw => nw.NetWorth)
                .IsRequired(true)
                .HasPrecision(10, 2);
        }
    }
}
