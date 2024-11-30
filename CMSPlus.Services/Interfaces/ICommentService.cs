using CMSPlus.Domain.Entities;

namespace CMSPlus.Services.Interfaces;

public interface ICommentService
{
    Task<IEnumerable<CommentEntity>> GetByTopicId(int topicId); // Fetch all comments for a topic
    Task AddComment(CommentEntity comment); // Add a new comment
}
