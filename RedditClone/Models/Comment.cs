using Humanizer.Localisation;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using RedditClone.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace RedditClone.Areas.Forums.Models;
public class Comment
{
    // EF will instruct the database to automatically generate this value
    public int CommentId { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
    public int UserId { get; set; }

    [Required(ErrorMessage = "Please enter text.")]
    public string? Body { get; set; }
    public DateTime Date { get; set; }
}