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
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(n => n.Name)
                .HasMaxLength(40)
                .IsRequired(true);
            builder.Property(r => r.ReleaseDate)
                .IsRequired(true);
            builder.Property(p => p.Price)
                .HasPrecision(10, 2);

        }
    }
}
