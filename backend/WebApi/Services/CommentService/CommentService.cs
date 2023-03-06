using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using WebApi.Models;

namespace WebApi.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private static List<Comment> comments = new List<Comment>()
            {
                new Comment()
                    {
                        Id= 1,
                        Title = "Title 1",
                        Content = "Comment 1",
                        User = new User()
                        {
                            Id = 1,
                            NickName = "User 1",
                            FirstName = "-",
                            AvatarUrl = ""
                        }
                    },
                new Comment()
                    {
                        Id= 2,
                        Title = "Title 2",
                        Content = "Comment 2",
                        User = new User()
                        {
                            Id = 2,
                            NickName = "User 2",
                            FirstName = "-",
                            AvatarUrl = ""
                        }

                    },
                new Comment()
                    {
                        Id= 3,
                        Title = "Title 3",
                        Content = "Comment 3",
                        User = new User()
                        {
                            Id = 1,
                            NickName = "User 1",
                            FirstName = "-",
                            AvatarUrl = ""
                        }

                    }
            };

        public async Task<Comment> AddComment(Comment comment)
        {
            comments.Add(comment);

            return comments.LastOrDefault();
        }

        public async Task<bool> DeleteComment(int id)
        {
            var dComment = comments.FirstOrDefault(x => x.Id == id);
            if(dComment!=null)
            {
                comments.Remove(dComment);
                return true;
            }

            return false;
        }

        public async Task<List<Comment>> GetAllComments()
        {
            return comments;
        }

        public async Task<Comment> GetComment(int id)
        {
            var sComment = comments.FirstOrDefault(x => x.Id == id);

            return sComment;
        }

        public async Task<Comment> UpdateComment(Comment comment)
        {
            var uComment = comments.FirstOrDefault(x => x.Id == comment.Id);

            if (uComment != null)
            {
                uComment.Title = comment.Title;
                uComment.Content = comment.Content;
            }

            return uComment;
        }
    }
}
