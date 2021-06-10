using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Infra.Data.Sql.Context;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infra.Data.Sql.Implementation
{
    public class EfBlogRepository : BlogRepository
    {
        private readonly EFDbContext _blogManagementDb;

        public EfBlogRepository(EFDbContext blogManagementDb)
        {
            _blogManagementDb = blogManagementDb;
        }
        public void Add(Blog blog)
        {
            _blogManagementDb.Add(blog);
            _blogManagementDb.SaveChanges();
        }

        public Blog Get(int blogId)
        {
            return _blogManagementDb.Blogs.FirstOrDefault(c => c.Id == blogId);
        }

        public List<Blog> Get()
        {
            return _blogManagementDb.Blogs.ToList();
        }

        public void Remove(int blogId)
        {
            var blog = new Blog
            {
                Id = blogId
            };
            _blogManagementDb.Blogs.Remove(blog);
            _blogManagementDb.SaveChanges();
        }
    }
}
