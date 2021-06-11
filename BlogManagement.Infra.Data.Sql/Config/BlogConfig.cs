using BlogManagement.Core.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogManagement.Infra.Data.Sql.Config
{
    public class BlogConfig : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.EnName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Desciption).IsRequired().HasMaxLength(500);
            builder.Property(p => p.RowVersion).IsConcurrencyToken();

            builder.ToTable("Blog");
        }
    }
}
