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

        public Task<Post> AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<Post> DeletePost(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetAllPosts()
        {
            return posts;
        }

        public Task<Post> GetPostById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
