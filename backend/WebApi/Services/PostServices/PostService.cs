using WebApi.Models;

namespace WebApi.Services.PostServices
{
    public class PostService : IPostService
    {
        private static List<Post> posts = new List<Post>()
        {
            new Post(){ 
                Id= 1,
                ImgUrl = "",
                Comments= new List<Comment>(){}
            }
        };

        public Task<ServiceResponse<Post>> AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Post>> DeletePost(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Post>>> GetAllPosts()
        {
            var servResponse = new ServiceResponse<List<Post>>() { 
                Data = posts
            };
            return servResponse;
        }

        public Task<ServiceResponse<Post>> GetPostById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Post>> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
