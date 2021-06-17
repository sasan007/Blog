using Golrang.Framework.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Golrang.Framework.Infra
{
    public class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(p => p.RowVersion).IsConcurrencyToken();
        }
    }
    // public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    // {
    //     public void Configure(EntityTypeBuilder<T> builder)
    //     {
    //         builder.Property(p => p.RowVersion).IsConcurrencyToken();
    //         HandleConfigure(builder);
    //     }
    //
    //     public abstract void HandleConfigure(EntityTypeBuilder<T> builder);
    // }
}