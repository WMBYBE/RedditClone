using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedditClone.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    ForumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.ForumId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Body", "Date", "PostId", "UserId" },
                values: new object[,]
                {
                    { 1, "Robocop is midwit slop :(.", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9686), 1, 2 },
                    { 2, "Robocop is midwit slop >:(.", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9689), 1, 3 },
                    { 3, "I dont watch movies.", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9691), 1, 4 },
                    { 4, "I like the robocop game", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9692), 2, 1 },
                    { 5, "nothing beats deus Ex.", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9693), 2, 2 },
                    { 7, "Bro got grinched lmao", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9695), 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "ForumId", "Name" },
                values: new object[,]
                {
                    { 1, "Movies" },
                    { 2, "Games" },
                    { 3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Body", "Date", "ForumId", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Mine is Robo-Cop :).", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9580), 1, "What is everyone's favorite movie?", 1 },
                    { 2, "Mine is Kane and Lynch 2: Dog Days :).", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9583), 2, "What is everyone's favorite game?", 2 },
                    { 3, "Mine is Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris ut mauris in nunc aliquam varius vitae a urna. Nunc mattis non metus non aliquam. Mauris in placerat eros, sed placerat felis. Sed massa lectus, hendrerit vitae massa vel, euismod malesuada tellus. Sed hendrerit tempus vehicula. Aenean sollicitudin lectus lectus, porta tempus est vehicula quis. Donec sagittis neque nulla, sit amet aliquam erat dignissim ac. Sed pharetra luctus erat eu tristique. Phasellus ullamcorper tincidunt metus, eget rutrum nisi faucibus ac. Cras at ultrices erat. Nulla posuere vestibulum felis, nec maximus dui malesuada id.\r\n\r\nDonec mi arcu, bibendum vitae dolor vel, auctor eleifend ex. Integer consequat orci porttitor urna bibendum vehicula at in odio. Integer finibus ullamcorper venenatis. Nullam sodales mi ac nibh posuere posuere ut luctus tellus. Mauris sed dignissim tortor. In porta vel arcu nec tristique. Fusce tincidunt et nisl quis consectetur. Vestibulum ante libero, pellentesque ut pretium id, egestas et neque. Maecenas dictum rhoncus odio sed lacinia. Nullam quis nisi libero. Duis consectetur accumsan metus non finibus. Sed interdum lectus nec aliquet dapibus. Praesent magna quam, placerat a accumsan at, elementum id augue. Nullam iaculis lorem vel malesuada dapibus.\r\n\r\nCurabitur interdum tristique massa, sit amet egestas lorem placerat id. Pellentesque magna urna, consectetur non nisl non, varius convallis metus. Pellentesque sagittis, est non sodales mollis, purus odio accumsan turpis, vel consectetur metus risus vitae sapien. Sed dictum vitae sem in condimentum. Duis et cursus ligula. Phasellus at lacus vel odio luctus convallis molestie et felis. Sed feugiat risus ex, id tempor felis aliquet id. Aenean sit amet mattis lacus. Phasellus pharetra pellentesque dui a volutpat. Aliquam feugiat metus nisi, ut dapibus libero consequat et. Curabitur vel turpis tellus. Fusce finibus erat in egestas mattis. Sed tincidunt mollis risus et rhoncus. Suspendisse aliquam mollis pretium. Etiam in erat eu ipsum rutrum tempus non sit amet ex. Integer sodales sed massa vitae tincidunt.\r\n\r\nMaecenas nec dui nec odio pulvinar blandit vel egestas nibh. Sed est mi, ornare at ante non, tempus consectetur augue. Donec rutrum est nec nibh feugiat porttitor. Sed tincidunt efficitur dignissim. Cras facilisis libero in turpis condimentum aliquet id in risus. Donec ac odio at tortor pharetra rhoncus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Maecenas mattis leo vel egestas mattis.\r\n\r\nPraesent posuere odio at justo maximus mollis. Fusce mattis eleifend lorem, nec euismod nibh mattis ut. Curabitur eget nisi iaculis, tristique sem eget, porta lacus. Pellentesque mollis sollicitudin lobortis. Mauris viverra eu eros sed fermentum. Cras rhoncus lacus nec nunc sollicitudin pharetra. Fusce semper, neque quis ultricies bibendum, ligula tortor ultricies justo, eget finibus ex mauris vestibulum sapien. Sed eu sapien nibh. Cras efficitur dui est, eget pellentesque libero posuere at. Curabitur efficitur lobortis urna quis dictum. Morbi quis vulputate mi, sed congue dui. In volutpat rhoncus convallis. Quisque non pharetra massa. :).", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9585), 3, "What is everyone's favorite other?", 1 },
                    { 4, "I liked adrian brodee in this movie but idk who made it. I tried to llok it up but just got something about a petition?", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9587), 1, "Who directed 'The Pianist?'", 3 },
                    { 5, "", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9589), 2, "Biggest game company of all time reports $0 of income for Q2 2025", 4 },
                    { 6, "I can believe it, the entire feast I prepared is gone. Who Pudding, Who Roast, even my ice box is nothing but crumbs left. \nThey even took my last can of Who hash... I think im going to be sick ", new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9590), 3, "My home was ransacked last night on christmas Eve", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name" },
                values: new object[,]
                {
                    { 1, "Wellernaught" },
                    { 2, "Thuggonomics" },
                    { 3, "ricflair12441" },
                    { 4, "PeterPumpkinEater" },
                    { 5, "FirstNameBunch0Numbas" },
                    { 6, "ReiGaan224" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
