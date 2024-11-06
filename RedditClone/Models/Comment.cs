using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;

namespace RedditClone.Areas.Forums.Models;
public class Comment
{
    // EF will instruct the database to automatically generate this value
    public int CommentId { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }

    [Required(ErrorMessage = "Please enter text.")]
    public string? Body { get; set; }
    public DateTime Date { get; set; }
}