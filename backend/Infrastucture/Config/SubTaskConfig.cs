using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Domain.Cores;
using backend.Models.Targets;

namespace backend.Infrastucture.Config
{
    public class SubTaskConfig : IEntityTypeConfiguration<Target>
    {
        public void Configure(EntityTypeBuilder<Target> builder)
        {
            builder.ToTable("SubTasks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
          // hanoz status monde ?????
          builder.Property(m=>m.Name).IsRequired();
        }
    }
}
