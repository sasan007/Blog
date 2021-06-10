using BlogManagement.Core.Domain.Domain;
using System.Collections.Generic;

namespace BlogManagement.Core.Domain.Repository
{
    public interface BlogRepository
    {
        void Add(Blog blog);
        void Remove(int blogId);

        Blog Get(int blogId);
        List<Blog> Get();

    }
}
