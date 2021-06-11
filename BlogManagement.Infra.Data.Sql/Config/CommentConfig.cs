using BlogManagement.Core.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogManagement.Infra.Data.Sql.Config
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(c => c.Text).IsRequired().HasMaxLength(300);
            builder.Property(p => p.RowVersion).IsConcurrencyToken();

            builder.HasOne(p => p.Post).WithMany(b => b.Comments);

            builder.ToTable("Comment");
        }
    }
}
