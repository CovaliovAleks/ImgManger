using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services.CommentService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService commentService = null;

        public CommentsController(ICommentService comService)
        {
            commentService = comService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Comment>>> Get()
        {
            return await commentService.GetAllComments();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> Get(int id)
        {
            var comment = await commentService.GetComment(id);
            if (comment == null)
                return BadRequest("Comment not found");

            return Ok(comment);
        }


        [HttpPost]
        public async Task<ActionResult<List<Comment>>> AddComment([FromForm] Comment coment)
        {
            var nComment = await commentService.AddComment(coment);

            return await commentService.GetAllComments();
        }

        [HttpPut]
        public async Task<ActionResult<List<Comment>>> UpdateComment([FromForm] Comment request)
        {
            var comment = await commentService.GetComment(request.Id);
            if (comment == null)
                return BadRequest("Comment not found");

            comment.Title = request.Title;
            comment.Content = request.Content;

            return await commentService.GetAllComments();
        }

    }
}
