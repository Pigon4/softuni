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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(80)
                .IsUnicode(true);
            builder.Property(x => x.Description)
                .IsUnicode(true)
                .IsRequired(false);
            builder.Property(x => x.Price)
                .HasPrecision(10, 2);
        }
    }
}
