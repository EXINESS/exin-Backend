using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Domain.Cores;
using static System.Net.Mime.MediaTypeNames;

namespace backend.Infrastucture.Config
{
    public class TargetConfig : IEntityTypeConfiguration<Target>
    {
        public void Configure(EntityTypeBuilder<Target> builder)
        {
            builder.ToTable("Target");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property<SubTask>("subTasks");
        }
    }
}
