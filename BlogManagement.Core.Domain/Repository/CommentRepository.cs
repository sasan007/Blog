using BlogManagement.Core.Domain.Domain;
using System.Collections.Generic;

namespace BlogManagement.Core.Domain.Repository
{
    public interface CommentRepository
    {
        void Add(Comment comment);
        void Remove(int commentId);

        Comment Get(int commentId);
        List<Comment> Get();

    }
}
