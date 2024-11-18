using Humanizer;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using RedditClone.Models;
using System.ComponentModel.DataAnnotations;

namespace RedditClone.Areas.Forums.Models;
public class Comment
{
    // EF will instruct the database to automatically generate this value
    public int CommentId { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required(ErrorMessage = "Please enter text.")]
    public string? Body { get; set; }
    public DateTime Date { get; set; }
}