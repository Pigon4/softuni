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
    public class SongsConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(n => n.Name)
                .HasMaxLength(20)
                .IsRequired(true);
            builder.Property(d => d.Duration)
                .IsRequired(true);
            builder.Property(c => c.CreatedOn)
                .IsRequired(true);
            builder.Property(g => g.Genre)
                .IsRequired(true);
            builder.Property(w => w.WriterId)
                .IsRequired(true);
            builder.Property(p => p.Price)
                .IsRequired(true)
                .HasPrecision(10, 2);

        }
    }
}
