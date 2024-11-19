using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;
using RedditClone.Models;

namespace RedditClone.Models;
public class User
{
    // EF will instruct the database to automatically generate this value
    public int UserId { get; set; }

 
    public string Name { get; set; }
    public string Password { get; set; }
    public string? Email { get; set; }

}