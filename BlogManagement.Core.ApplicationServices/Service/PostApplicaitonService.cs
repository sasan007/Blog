using BlogManagement.Core.ApplicationServices.Command.Posts;
using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using System.Collections.Generic;

namespace BlogManagement.Core.ApplicationServices.Service
{
    public class PostApplicaitonService
    {
        private readonly PostRepository _postRepository;
        private readonly ReviewRepository _reviewRepository;

        public PostApplicaitonService(PostRepository postRepository,ReviewRepository reviewRepository)
        {
            _postRepository = postRepository;
            _reviewRepository = reviewRepository;
        }

        public void Create(CreatePostCommand command)
        {
            _postRepository.Add(command.ToPost());
        }
        public void Update(UpdatePostCommand command)
        {
            _postRepository.Update(command.ToPost());
        }
        public Post Get(int PostId)
        {
            var post = _postRepository.Get(PostId);
            _reviewRepository.Add(new CreateReviewCommand(post.Id).ToReview());
            return post;

        }

        public List<Post> Get()
        {
            return _postRepository.Get();
        }

        public void Remove(RemovePostCommand command)
        {
            _postRepository.Remove(command.Id);
        }
    }
}
