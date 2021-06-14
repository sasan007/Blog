using BlogManagement.Core.ApplicationServices.Command.Comments;
using BlogManagement.Core.ApplicationServices.Service;
using BlogManagement.Core.Domain.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CommentManagement.Endpoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly CommentApplicaitonService _CommentApplicaitonService;

        public CommentController(CommentApplicaitonService CommentApplicaitonService)
        {
            _CommentApplicaitonService = CommentApplicaitonService;
        }

        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _CommentApplicaitonService.Get();
        }
        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            return _CommentApplicaitonService.Get(id);
        }

        [HttpPost]
        public IActionResult Create(CreateCommentCommand command)
        {
            _CommentApplicaitonService.Add(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(RemoveCommentCommand command)
        {
            _CommentApplicaitonService.Remove(command);
            return NoContent();
        }
    }
}
