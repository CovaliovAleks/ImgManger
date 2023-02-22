namespace WebApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }

        public int Likes { get; set; }

        public List<Comment> Comments { get; set; }


    }
}
