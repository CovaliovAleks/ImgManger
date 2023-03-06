using WebApi.Models;

namespace WebApi.Services.PostServices
{
    public interface IPostService
    {
        Task<List<Post>> GetAllPosts();

        Task<Post> AddPost(Post post);

        Task<Post> UpdatePost(Post post);

        Task<Post> DeletePost(Post post);

        Task<Post> GetPostById(int id);
    }
}
