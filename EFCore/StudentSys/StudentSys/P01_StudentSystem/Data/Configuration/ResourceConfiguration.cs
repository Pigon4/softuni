using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentSys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Data.Configuration
{
    public class ResourcesConfiguration : IEntityTypeConfiguration<Resources>
    {
        public void Configure(EntityTypeBuilder<Resources> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsUnicode(true);
            builder.Property(x => x.Url)
                .IsUnicode(false);

        }
    }
}
