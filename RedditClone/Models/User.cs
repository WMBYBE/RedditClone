using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;
using RedditClone.Models;

namespace RedditClone.Models;
public class User
{
    // EF will instruct the database to automatically generate this value
    public int UserId { get; set; }

    [Required(ErrorMessage = "Please enter a Username.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please enter a Password.")]
    public string Password { get; set; }
    public string? Email { get; set; }

}