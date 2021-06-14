using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Infra.Data.Sql.Context;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infra.Data.Sql.Implementation
{
    public class EfPostRepository : PostRepository
    {
        private readonly EFDbContext _PostManagementDb;

        public EfPostRepository(EFDbContext PostManagementDb)
        {
            _PostManagementDb = PostManagementDb;
        }
        public void Add(Post Post)
        {
            _PostManagementDb.Add(Post);
            _PostManagementDb.SaveChanges();
        }
        public void Update(Post post)
        {
            _PostManagementDb.Update(post);
            _PostManagementDb.SaveChanges();
        }

        public Post Get(int PostId)
        {
            return _PostManagementDb.Posts.FirstOrDefault(c => c.Id == PostId);
        }

        public List<Post> Get()
        {
            return _PostManagementDb.Posts.ToList();
        }

        public void Remove(int PostId)
        {
            var Post = new Post
            {
                Id = PostId
            };
            _PostManagementDb.Posts.Remove(Post);
            _PostManagementDb.SaveChanges();
        }
    }
}
