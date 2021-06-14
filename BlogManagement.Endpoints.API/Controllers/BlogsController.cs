using BlogManagement.Core.ApplicationServices.Command.Blogs;
using BlogManagement.Core.ApplicationServices.Service;
using BlogManagement.Core.Domain.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogManagement.Endpoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BlogApplicaitonService _blogApplicaitonService;

        public BlogController(BlogApplicaitonService blogApplicaitonService)
        {
            _blogApplicaitonService = blogApplicaitonService;
        }

        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return _blogApplicaitonService.Get();
        }
        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            return _blogApplicaitonService.Get(id);
        }

        [HttpPost]
        public IActionResult Add(CreateBlogCommand command)
        {
            _blogApplicaitonService.Add(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(RemoveBlogCommand command)
        {
            _blogApplicaitonService.Remove(command);
            return NoContent();
        }
    }
}
