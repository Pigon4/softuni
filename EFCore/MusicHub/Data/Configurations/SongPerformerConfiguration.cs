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
    public class SongPerformerConfiguration : IEntityTypeConfiguration<SongPerformer>
    {
        public void Configure(EntityTypeBuilder<SongPerformer> builder)
        {
            builder.HasKey(x => new { x.PerformerId, x.SongId });
            /*builder.Property(s => s.Song)
                .IsRequired(true);  
            builder.Property(p => p.Performer)
                .IsRequired(true);*/
        }
    }
}
