using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private static List<Comment> comments= new List<Comment>()
            {
                new Comment()
                    {
                        Id= 1,
                        Title = "Title 1",
                        Content = "Comment 1",
                        UserName = "User 1"
                    }
            };



        [HttpGet]
        public async Task<ActionResult<List<Comment>>> Get()
        {
            return Ok(comments);
        }

        [HttpPost]
        public async Task<ActionResult<List<Comment>>> AddComment(Comment coment)
        {
            comments.Add(coment);

            return Ok(comments);
        }


    }
}
