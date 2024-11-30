using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSPlus.Domain.Entities;

public class CommentEntity : BaseEntity
{
    [Required] 
    public string Name { get; set; } = null!; 

    [Required]
    public string Content { get; set; } = null!; 

    [Required]
    public int TopicId { get; set; } 

    [ForeignKey(nameof(TopicId))]
    public TopicEntity Topic { get; set; } = null!; 
}
