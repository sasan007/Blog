using BlogManagement.Core.ApplicationServices.Command.Posts;
using BlogManagement.Core.Domain.Repository;

namespace BlogManagement.Core.ApplicationServices.Service
{
    public class ReviewApplicaitonService
    {
        private readonly ReviewRepository _ReviewRepository;

        public ReviewApplicaitonService(ReviewRepository ReviewRepository)
        {
            _ReviewRepository = ReviewRepository;
        }

        public void Create(CreateReviewCommand command)
        {
            _ReviewRepository.Add(command.ToReview());
        }
    }
}
