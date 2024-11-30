using System.ComponentModel.DataAnnotations;

namespace CMSPlus.Domain.Models.TopicModels;

public class CommentCreateModel
{
    [Required]
    public int TopicId { get; set; } 

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = null!; 

    [Required(ErrorMessage = "Comment cannot be empty.")]
    public string Content { get; set; } = null!; 
}
