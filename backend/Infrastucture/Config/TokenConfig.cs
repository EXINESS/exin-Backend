using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Domain.Cores;

namespace backend.Infrastucture.Config
{
    public class TokenConfig : IEntityTypeConfiguration<Token>
    {
        public void Configure(EntityTypeBuilder<Token> builder)
        {
            builder.ToTable("Tokens");
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.Timeout);
            builder.Property(x => x.token ).IsRequired();

        }
    }
}
