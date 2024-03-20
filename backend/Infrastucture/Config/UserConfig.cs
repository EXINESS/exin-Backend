using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Domain.Cores.UserAggregate;

namespace backend.Infrastucture.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Username).IsRequired();
            builder.Property(x=>x.Password).IsRequired();
            builder.Property(x=>x.N).IsRequired();
        }
    }
}
