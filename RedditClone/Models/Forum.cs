using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;

namespace RedditClone.Areas.Forums.Models;
    public class Forum
    {
            // EF will instruct the database to automatically generate this value
            public int ForumId { get; set; }

            [Required(ErrorMessage = "Please enter a name.")]
            public string Name { get; set; }
    }