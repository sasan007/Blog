using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Infra.Data.Sql.Context;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infra.Data.Sql.Implementation
{
    public class EfReviewRepository : ReviewRepository
    {
        private readonly EFDbContext _ReviewManagementDb;

        public EfReviewRepository(EFDbContext ReviewManagementDb)
        {
            _ReviewManagementDb = ReviewManagementDb;
        }
        public void Add(Review Review)
        {
            _ReviewManagementDb.Add(Review);
            _ReviewManagementDb.SaveChanges();
        }

        public Review Get(int ReviewId)
        {
            return _ReviewManagementDb.Reviews.FirstOrDefault(c => c.Id == ReviewId);
        }

        public List<Review> Get()
        {
            return _ReviewManagementDb.Reviews.ToList();
        }

    }
}
