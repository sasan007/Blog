using Golrang.Framework.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golrang.Framework.Infra
{
    public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(p => p.RowVersion).IsConcurrencyToken();
            Handle(builder);
        }

        public abstract void Handle(EntityTypeBuilder<T> builder);
    }
}