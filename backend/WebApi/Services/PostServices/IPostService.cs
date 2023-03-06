using WebApi.Models;

namespace WebApi.Services.PostServices
{
    public interface IPostService
    {
        Task<ServiceResponse<List<Post>>> GetAllPosts();

        Task<ServiceResponse<Post>> AddPost(Post post);

        Task<ServiceResponse<Post>> UpdatePost(Post post);

        Task<ServiceResponse<Post>> DeletePost(Post post);

        Task<ServiceResponse<Post>> GetPostById(int id);
    }
}
