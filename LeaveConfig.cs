using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1tomany
{
    public class LeaveConfig : IEntityTypeConfiguration<Leave>
    {
        public void Configure(EntityTypeBuilder<Leave> builder)
        {
            builder.ToTable("T_Leave");
            builder.HasOne<User>(l => l.Requester).WithMany();
            builder.HasOne<User>(l => l.Approver).WithMany();
            builder.Property(l => l.Remarks).HasMaxLength(1000).IsUnicode();
        }
    }
}
