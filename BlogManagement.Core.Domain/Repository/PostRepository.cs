using BlogManagement.Core.Domain.Domain;
using System.Collections.Generic;

namespace BlogManagement.Core.Domain.Repository
{
    public interface PostRepository
    {
        void Add(Post post);
        void Update(Post post); 
        void Remove(int postId);

        Post Get(int postId);
        List<Post> Get();

    }
}
