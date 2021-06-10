using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Infra.Data.Sql.Context;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infra.Data.Sql.Implementation
{
    public class EfCommentRepository : CommentRepository
    {
        private readonly EFDbContext _context;

        public EfCommentRepository(EFDbContext context)
        {
            _context = context;
        }
        public void Add(Comment Comment)
        {
            _context.Add(Comment);
            _context.SaveChanges();
        }

        public Comment Get(int CommentId)
        {
            return _context.Comments.FirstOrDefault(c => c.Id == CommentId);
        }

        public List<Comment> Get()
        {
            return _context.Comments.ToList();
        }

        public void Remove(int CommentId)
        {
            var Comment = new Comment
            {
                Id = CommentId
            };
            _context.Comments.Remove(Comment);
            _context.SaveChanges();
        }
    }
}
