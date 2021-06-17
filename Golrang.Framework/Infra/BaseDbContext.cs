using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golrang.Framework.Infra
{
    public abstract class BaseDbContext
    {
        private DbContext _dbContext;
        public BaseDbContext(DbContextOptions options)
        {
            _dbContext = new DbContext(options);
        }
        public EntityEntry Add(object entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return Add(entity);
        }
        public EntityEntry Update(object entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return Update(entity);
        }
        public EntityEntry Remove(object entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return Remove(null);
        }

    }
}
