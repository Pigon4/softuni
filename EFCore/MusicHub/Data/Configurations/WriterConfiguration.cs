using Microsoft.EntityFrameworkCore;
using System;
using MusicHub.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicHub.Data.Configurations
{
    public class WriterConfiguration : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(n => n.Name)
                .HasMaxLength(20)
                .IsRequired(true);
        }
    }
}
