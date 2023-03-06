using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services.CommentService;
using WebApi.Services.PostServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService postService = null;
        public PostController(IPostService ptService) 
        {
            postService = ptService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Post>>>> Get()
        {
            return await postService.GetAllPosts();
        }



    }
}
