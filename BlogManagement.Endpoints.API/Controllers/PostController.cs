using BlogManagement.Core.ApplicationServices.Command.Posts;
using BlogManagement.Core.Domain.Domain;
using PostManagement.Core.ApplicationServices.Service.Posts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PostManagement.Endpoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly PostApplicaitonService _PostApplicaitonService;

        public PostController(PostApplicaitonService PostApplicaitonService)
        {
            _PostApplicaitonService = PostApplicaitonService;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _PostApplicaitonService.Get();
        }
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return _PostApplicaitonService.Get(id);
        }

        [HttpPost]
        public IActionResult Create(CreatePostCommand command)
        {
            _PostApplicaitonService.Create(command);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdatePostCommand command)
        {
            _PostApplicaitonService.Update(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(RemovePostCommand command)
        {
            _PostApplicaitonService.Remove(command);
            return NoContent();
        }
    }
}
