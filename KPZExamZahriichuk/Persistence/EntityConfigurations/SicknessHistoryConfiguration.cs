using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class SicknessHistoryConfiguration : IEntityTypeConfiguration<SicknessHistory>
{
    public void Configure(EntityTypeBuilder<SicknessHistory> builder)
    {
        builder.ToTable("SicknessHistories");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasOne(x => x.Doctor);

        builder.HasOne(x => x.Patient);
    }
}
