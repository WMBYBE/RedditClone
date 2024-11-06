using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;

namespace RedditClone.Areas.Forums.Models
{
    public class ForumDBContext : DbContext
    {
        public ForumDBContext(DbContextOptions<ForumDBContext> options)
            : base(options)
        { }

        public DbSet<Forum> Forums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Forum>().HasData(
                new Forum
                {
                    ForumId = 1,
                    Name = "Movies"
                },
                new Forum
                {
                    ForumId = 2,
                    Name = "Games"
                },
                new Forum
                {
                    ForumId = 3,
                    Name = "Other"
                }
            );
        }
    }
}
