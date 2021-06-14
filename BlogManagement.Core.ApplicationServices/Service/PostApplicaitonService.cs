using BlogManagement.Core.ApplicationServices.Command.Posts;
using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using System.Collections.Generic;

namespace BlogManagement.Core.ApplicationServices.Service
{
    public class PostApplicaitonService
    {
        private readonly PostRepository _PostRepository;

        public PostApplicaitonService(PostRepository PostRepository)
        {
            _PostRepository = PostRepository;
        }

        public void Create(CreatePostCommand command)
        {
            _PostRepository.Add(command.ToPost());
        }
        public void Update(UpdatePostCommand command)
        {
            _PostRepository.Update(command.ToPost());
        }
        public Post Get(int PostId)
        {
            return _PostRepository.Get(PostId);
        }

        public List<Post> Get()
        {
            return _PostRepository.Get();
        }

        public void Remove(RemovePostCommand command)
        {
            _PostRepository.Remove(command.Id);
        }
    }
}
