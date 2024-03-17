using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Domain.Cores;

namespace backend.Infrastucture.Config
{
    public class FeedbackConfig : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.ToTable("Feedbacks");
            builder.HasKey(x => x.Id);
            builder.Property(m => m.UserId).IsRequired();
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
