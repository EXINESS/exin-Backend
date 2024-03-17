using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Domain.Cores.AchiveAggregate;

namespace backend.Infrastucture.Config
{
    public class AchiveConfig : IEntityTypeConfiguration<Achive>
    {
        public void Configure(EntityTypeBuilder<Achive> builder)
        {
            builder.ToTable("Achives");
            builder.HasKey(x => x.Id);
            builder.Property(m=>m.UserId);
            builder.Property(m => m.Description).IsRequired();
        }
    }
}
