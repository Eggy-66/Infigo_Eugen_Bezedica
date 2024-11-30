namespace CMSPlus.Domain.Models.TopicModels;

public class CommentViewModel
{
    public string Name { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime CreatedOnUtc { get; set; } 
}
