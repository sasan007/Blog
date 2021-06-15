using BlogManagement.Core.Domain.Domain;
using Golrang.Framework.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogManagement.Infra.Data.Sql.Config
{
    public class BlogConfig : BaseConfig<Blog>
    {
        //public void Configure(EntityTypeBuilder<Blog> builder)
        //{
        //    builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        //    builder.Property(c => c.EnName).IsRequired().HasMaxLength(100);
        //    builder.Property(c => c.Desciption).IsRequired().HasMaxLength(500);
        //    builder.Property(p => p.RowVersion).IsConcurrencyToken();

        //    builder.ToTable("Blog");
        //}
        public override void Handle(EntityTypeBuilder<Blog> builder)
        {

        }
    }
}
