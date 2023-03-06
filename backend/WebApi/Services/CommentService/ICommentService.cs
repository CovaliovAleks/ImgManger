using WebApi.Models;

namespace WebApi.Services.CommentService
{
    public interface ICommentService
    {
        Task<List<Comment>> GetAllComments();
        Task<Comment> GetComment(int id);
        Task<Comment> AddComment(Comment comment);
        Task<Comment> UpdateComment(Comment comment);
        Task<bool> DeleteComment(int id);
        
    }
}
