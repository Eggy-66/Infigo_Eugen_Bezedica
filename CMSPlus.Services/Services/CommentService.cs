using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Persistance;
using CMSPlus.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CMSPlus.Services;

public class CommentService : ICommentService
{
    private readonly ApplicationDbContext _dbContext;

    public CommentService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<CommentEntity>> GetByTopicId(int topicId)
    {
        return await _dbContext.Comments
            .Where(c => c.TopicId == topicId)
            .OrderBy(c => c.CreatedOnUtc)
            .ToListAsync();
    }

    public async Task AddComment(CommentEntity comment)
    {
        await _dbContext.Comments.AddAsync(comment);
        await _dbContext.SaveChangesAsync();
    }
}
