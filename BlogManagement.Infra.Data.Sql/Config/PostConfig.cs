using BlogManagement.Core.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogManagement.Infra.Data.Sql.Config
{
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(c => c.Title).IsRequired().HasMaxLength(50);
            builder.Property(c => c.BlogId).IsRequired();
            builder.Property(c => c.Content).IsRequired().HasMaxLength(500);
            builder.Property(p => p.RowVersion).IsConcurrencyToken();

            builder.HasOne(p => p.Blog).WithMany(b => b.Posts).HasForeignKey(f => f.BlogId);

            builder.ToTable("Post");
        }
    }
}
