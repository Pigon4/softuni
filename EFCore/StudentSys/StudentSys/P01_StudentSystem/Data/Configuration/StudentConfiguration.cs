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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(true)
                .IsRequired(false);
            builder.Property(x => x.Birthday)
                .IsRequired(false);
        }
    }
}
