using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;

namespace RedditClone.Models;
public class User
{
    // EF will instruct the database to automatically generate this value
    public int UserId { get; set; }

    [Required(ErrorMessage = "Please enter a UserName.")]
    public string? Name { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }

}