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
        private DbContext _dbContext;
        public BaseDbContext(DbContextOptions options)
        {
            _dbContext = new DbContext(options);
        }
        public override EntityEntry Add(object entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return Entry(entity);
        }
        public override EntityEntry Update(object entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return Entry(entity);
        }
        public override EntityEntry Remove(object entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return Entry(null);
        }

    }
}
