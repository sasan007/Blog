using BlogManagement.Core.ApplicationServices.Command.Blogs;
using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using System.Collections.Generic;

namespace BlogManagement.Core.ApplicationServices.Service
{
    public class BlogApplicaitonService
    {
        private readonly BlogRepository _blogRepository;

        public BlogApplicaitonService(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void Add(CreateBlogCommand command)
        {
            _blogRepository.Add(command.ToBlog());
        }

        public Blog Get(int blogId)
        {
            return _blogRepository.Get(blogId);
        }

        public List<Blog> Get()
        {
            return _blogRepository.Get();
        }

        public void Remove(RemoveBlogCommand command)
        {
            _blogRepository.Remove(command.Id);
        }
    }
}
