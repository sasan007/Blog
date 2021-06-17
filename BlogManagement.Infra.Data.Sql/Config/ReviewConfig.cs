using BlogManagement.Core.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogManagement.Infra.Data.Sql.Config
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(c => c.PostId).IsRequired();
            builder.Property(p => p.RowVersion).IsConcurrencyToken();

            builder.HasOne(p => p.Post).WithMany(b => b.Reviews).HasForeignKey(f => f.PostId);
            builder.ToTable("Review");
        }
    }
}
