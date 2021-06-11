using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golrang.Framework.Infra
{
    public abstract class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options)
        : base(options)
        {
        }
        public override EntityEntry Add(object entity)
        {
            base.Add(entity);
            base.SaveChanges();
            return Entry(entity);
        }
        public override EntityEntry Update(object entity)
        {
            base.Update(entity);
            base.SaveChanges();
            return Entry(entity);
        }
        public override EntityEntry Remove(object entity)
        {
            base.Remove(entity);
            base.SaveChanges();
            return Entry(null);
        }
    }
}
