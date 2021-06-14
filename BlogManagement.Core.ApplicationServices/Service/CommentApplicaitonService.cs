using BlogManagement.Core.ApplicationServices.Command.Comments;
using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using System.Collections.Generic;

namespace BlogManagement.Core.ApplicationServices.Service
{
    public class CommentApplicaitonService
    {
        private readonly CommentRepository _CommentRepository;

        public CommentApplicaitonService(CommentRepository CommentRepository)
        {
            _CommentRepository = CommentRepository;
        }

        public void Add(CreateCommentCommand command)
        {
            _CommentRepository.Add(command.ToComment());
        }

        public Comment Get(int CommentId)
        {
            return _CommentRepository.Get(CommentId);
        }

        public List<Comment> Get()
        {
            return _CommentRepository.Get();
        }

        public void Remove(RemoveCommentCommand command)
        {
            _CommentRepository.Remove(command.Id);
        }
    }
}
