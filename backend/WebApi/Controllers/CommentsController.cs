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
                    },
                new Comment()
                    {
                        Id= 2,
                        Title = "Title 2",
                        Content = "Comment 2",
                        UserName = "User 1"
                    },
                new Comment()
                    {
                        Id= 3,
                        Title = "Title 3",
                        Content = "Comment 3",
                        UserName = "User 2"
                    }
            };


        [HttpGet]
        public async Task<ActionResult<List<Comment>>> Get()
        {
            return comments;
        }

        [HttpPost]
        public async Task<ActionResult<List<Comment>>> AddComment(Comment coment)
        {
            comments.Add(coment);

            return comments;
        }


    }
}
