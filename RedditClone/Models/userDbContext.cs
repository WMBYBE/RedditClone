using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;

namespace RedditClone.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "Wellernaught"
                },
                new User
                {
                    UserId = 2,
                    Name = "Thuggonomics"
                },
                new User
                {
                    UserId = 3,
                    Name = "ricflair12441"
                },
                new User
                {
                    UserId = 4,
                    Name = "PeterPumpkinEater"
                },
                new User
                {
                    UserId = 5,
                    Name = "FirstNameBunch0Numbas"
                },
                new User
                {
                    UserId = 6,
                    Name = "ReiGaan224"
                }

            );
        }
    }
}
