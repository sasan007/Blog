using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Infra.Data.Sql.Context;
using Golrang.Framework.Infra;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infra.Data.Sql.Implementation
{
    public class EfReviewRepository : EFRepository<Review>, ReviewRepository
    {
        public EfReviewRepository(EFDbContext context) : base(context)
        {
        }
    }
}
