using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;

namespace RedditClone.Areas.Forums.Models
{
    public class PostDBContext : DbContext
    {
        public PostDBContext(DbContextOptions<ForumDBContext> options)
            : base(options)
        { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    ForumId = 1,
                    UserId = 1,
                    Title = "What is everyone's favorite movie?",
                    Body = "Mine is Robo-Cop :).",
                    Date = DateTime.UtcNow
                },
                new Post
                {
                    PostId = 2,
                    ForumId = 2,
                    UserId = 2,
                    Title = "What is everyone's favorite game?",
                    Body = "Mine is Kane and Lynch 2: Dog Days :).",
                    Date = DateTime.UtcNow
                },
                new Post
                {
                    PostId = 3,
                    ForumId = 3,
                    UserId = 1,
                    Title = "What is everyone's favorite other?",
                    Body = "Mine is Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris ut mauris in nunc aliquam varius vitae a urna. Nunc mattis non metus non aliquam. Mauris in placerat eros, sed placerat felis. Sed massa lectus, hendrerit vitae massa vel, euismod malesuada tellus. Sed hendrerit tempus vehicula. Aenean sollicitudin lectus lectus, porta tempus est vehicula quis. Donec sagittis neque nulla, sit amet aliquam erat dignissim ac. Sed pharetra luctus erat eu tristique. Phasellus ullamcorper tincidunt metus, eget rutrum nisi faucibus ac. Cras at ultrices erat. Nulla posuere vestibulum felis, nec maximus dui malesuada id.\r\n\r\nDonec mi arcu, bibendum vitae dolor vel, auctor eleifend ex. Integer consequat orci porttitor urna bibendum vehicula at in odio. Integer finibus ullamcorper venenatis. Nullam sodales mi ac nibh posuere posuere ut luctus tellus. Mauris sed dignissim tortor. In porta vel arcu nec tristique. Fusce tincidunt et nisl quis consectetur. Vestibulum ante libero, pellentesque ut pretium id, egestas et neque. Maecenas dictum rhoncus odio sed lacinia. Nullam quis nisi libero. Duis consectetur accumsan metus non finibus. Sed interdum lectus nec aliquet dapibus. Praesent magna quam, placerat a accumsan at, elementum id augue. Nullam iaculis lorem vel malesuada dapibus.\r\n\r\nCurabitur interdum tristique massa, sit amet egestas lorem placerat id. Pellentesque magna urna, consectetur non nisl non, varius convallis metus. Pellentesque sagittis, est non sodales mollis, purus odio accumsan turpis, vel consectetur metus risus vitae sapien. Sed dictum vitae sem in condimentum. Duis et cursus ligula. Phasellus at lacus vel odio luctus convallis molestie et felis. Sed feugiat risus ex, id tempor felis aliquet id. Aenean sit amet mattis lacus. Phasellus pharetra pellentesque dui a volutpat. Aliquam feugiat metus nisi, ut dapibus libero consequat et. Curabitur vel turpis tellus. Fusce finibus erat in egestas mattis. Sed tincidunt mollis risus et rhoncus. Suspendisse aliquam mollis pretium. Etiam in erat eu ipsum rutrum tempus non sit amet ex. Integer sodales sed massa vitae tincidunt.\r\n\r\nMaecenas nec dui nec odio pulvinar blandit vel egestas nibh. Sed est mi, ornare at ante non, tempus consectetur augue. Donec rutrum est nec nibh feugiat porttitor. Sed tincidunt efficitur dignissim. Cras facilisis libero in turpis condimentum aliquet id in risus. Donec ac odio at tortor pharetra rhoncus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Maecenas mattis leo vel egestas mattis.\r\n\r\nPraesent posuere odio at justo maximus mollis. Fusce mattis eleifend lorem, nec euismod nibh mattis ut. Curabitur eget nisi iaculis, tristique sem eget, porta lacus. Pellentesque mollis sollicitudin lobortis. Mauris viverra eu eros sed fermentum. Cras rhoncus lacus nec nunc sollicitudin pharetra. Fusce semper, neque quis ultricies bibendum, ligula tortor ultricies justo, eget finibus ex mauris vestibulum sapien. Sed eu sapien nibh. Cras efficitur dui est, eget pellentesque libero posuere at. Curabitur efficitur lobortis urna quis dictum. Morbi quis vulputate mi, sed congue dui. In volutpat rhoncus convallis. Quisque non pharetra massa. :).",
                    Date = DateTime.UtcNow
                },
                new Post
                {
                    PostId = 4,
                    ForumId = 1,
                    UserId = 3,
                    Title = "Who directed 'The Pianist?'",
                    Body = "I liked adrian brodee in this movie but idk who made it. I tried to llok it up but just got something about a petition?",
                    Date = DateTime.UtcNow
                },
                new Post
                {
                    PostId = 5,
                    ForumId = 2,
                    UserId = 4,
                    Title = "Biggest game company of all time reports $0 of income for Q2 2025",
                    Body = "",
                    Date = DateTime.UtcNow
                },
                new Post
                {
                    PostId = 6,
                    ForumId = 3,
                    UserId = 4,
                    Title = "My home was ransacked last night on christmas Eve",
                    Body = "I can believe it, the entire feast I prepared is gone. Who Pudding, Who Roast, even my ice box is nothing but crumbs left. \n" +
                    "They even took my last can of Who hash... I think im going to be sick "
                    Date = DateTime.UtcNow
                }
            );
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    PostId = 1,
                    UserId = 2,
                    Body = "Robocop is midwit slop :(.",
                    Date = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 2,
                    PostId = 1,
                    UserId = 3,
                    Body = "Robocop is midwit slop >:(.",
                    Date = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 3,
                    PostId = 1,
                    UserId = 4,
                    Body = "I dont watch movies.",
                    Date = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 4,
                    PostId = 2,
                    UserId = 1,
                    Body = "I like the robocop game",
                    Date = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 5,
                    PostId = 2,
                    UserId = 2,
                    Body = "nothing beats deus Ex.",
                    Date = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 7,
                    PostId = 6,
                    UserId = 6,
                    Body = "Bro got grinched lmao",
                    Date = DateTime.UtcNow
                }
            );
        }
    }
}
