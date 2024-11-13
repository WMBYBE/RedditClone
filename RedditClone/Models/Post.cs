﻿using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;

namespace RedditClone.Areas.Forums.Models;
public class Post
{
    // EF will instruct the database to automatically generate this value
    public int PostId { get; set; }
    public int ForumId { get; set; }
    public int UserId { get; set; }

    [Required(ErrorMessage = "Please enter a name.")]
    public string? Title { get; set; }
    public string? Body { get; set; }
    public DateTime Date { get; set; }
}