﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedditClone.Models;

#nullable disable

namespace RedditClone.Migrations
{
    [DbContext(typeof(ForumDbContext))]
    partial class ForumDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RedditClone.Areas.Forums.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            Body = "Robocop is midwit slop :(.",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9686),
                            PostId = 1,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 2,
                            Body = "Robocop is midwit slop >:(.",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9689),
                            PostId = 1,
                            UserId = 3
                        },
                        new
                        {
                            CommentId = 3,
                            Body = "I dont watch movies.",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9691),
                            PostId = 1,
                            UserId = 4
                        },
                        new
                        {
                            CommentId = 4,
                            Body = "I like the robocop game",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9692),
                            PostId = 2,
                            UserId = 1
                        },
                        new
                        {
                            CommentId = 5,
                            Body = "nothing beats deus Ex.",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9693),
                            PostId = 2,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 7,
                            Body = "Bro got grinched lmao",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9695),
                            PostId = 6,
                            UserId = 6
                        });
                });

            modelBuilder.Entity("RedditClone.Areas.Forums.Models.Forum", b =>
                {
                    b.Property<int>("ForumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ForumId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ForumId");

                    b.ToTable("Forums", (string)null);

                    b.HasData(
                        new
                        {
                            ForumId = 1,
                            Name = "Movies"
                        },
                        new
                        {
                            ForumId = 2,
                            Name = "Games"
                        },
                        new
                        {
                            ForumId = 3,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("RedditClone.Areas.Forums.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"), 1L, 1);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ForumId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.ToTable("Posts", (string)null);

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Body = "Mine is Robo-Cop :).",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9580),
                            ForumId = 1,
                            Title = "What is everyone's favorite movie?",
                            UserId = 1
                        },
                        new
                        {
                            PostId = 2,
                            Body = "Mine is Kane and Lynch 2: Dog Days :).",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9583),
                            ForumId = 2,
                            Title = "What is everyone's favorite game?",
                            UserId = 2
                        },
                        new
                        {
                            PostId = 3,
                            Body = "Mine is Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris ut mauris in nunc aliquam varius vitae a urna. Nunc mattis non metus non aliquam. Mauris in placerat eros, sed placerat felis. Sed massa lectus, hendrerit vitae massa vel, euismod malesuada tellus. Sed hendrerit tempus vehicula. Aenean sollicitudin lectus lectus, porta tempus est vehicula quis. Donec sagittis neque nulla, sit amet aliquam erat dignissim ac. Sed pharetra luctus erat eu tristique. Phasellus ullamcorper tincidunt metus, eget rutrum nisi faucibus ac. Cras at ultrices erat. Nulla posuere vestibulum felis, nec maximus dui malesuada id.\r\n\r\nDonec mi arcu, bibendum vitae dolor vel, auctor eleifend ex. Integer consequat orci porttitor urna bibendum vehicula at in odio. Integer finibus ullamcorper venenatis. Nullam sodales mi ac nibh posuere posuere ut luctus tellus. Mauris sed dignissim tortor. In porta vel arcu nec tristique. Fusce tincidunt et nisl quis consectetur. Vestibulum ante libero, pellentesque ut pretium id, egestas et neque. Maecenas dictum rhoncus odio sed lacinia. Nullam quis nisi libero. Duis consectetur accumsan metus non finibus. Sed interdum lectus nec aliquet dapibus. Praesent magna quam, placerat a accumsan at, elementum id augue. Nullam iaculis lorem vel malesuada dapibus.\r\n\r\nCurabitur interdum tristique massa, sit amet egestas lorem placerat id. Pellentesque magna urna, consectetur non nisl non, varius convallis metus. Pellentesque sagittis, est non sodales mollis, purus odio accumsan turpis, vel consectetur metus risus vitae sapien. Sed dictum vitae sem in condimentum. Duis et cursus ligula. Phasellus at lacus vel odio luctus convallis molestie et felis. Sed feugiat risus ex, id tempor felis aliquet id. Aenean sit amet mattis lacus. Phasellus pharetra pellentesque dui a volutpat. Aliquam feugiat metus nisi, ut dapibus libero consequat et. Curabitur vel turpis tellus. Fusce finibus erat in egestas mattis. Sed tincidunt mollis risus et rhoncus. Suspendisse aliquam mollis pretium. Etiam in erat eu ipsum rutrum tempus non sit amet ex. Integer sodales sed massa vitae tincidunt.\r\n\r\nMaecenas nec dui nec odio pulvinar blandit vel egestas nibh. Sed est mi, ornare at ante non, tempus consectetur augue. Donec rutrum est nec nibh feugiat porttitor. Sed tincidunt efficitur dignissim. Cras facilisis libero in turpis condimentum aliquet id in risus. Donec ac odio at tortor pharetra rhoncus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Maecenas mattis leo vel egestas mattis.\r\n\r\nPraesent posuere odio at justo maximus mollis. Fusce mattis eleifend lorem, nec euismod nibh mattis ut. Curabitur eget nisi iaculis, tristique sem eget, porta lacus. Pellentesque mollis sollicitudin lobortis. Mauris viverra eu eros sed fermentum. Cras rhoncus lacus nec nunc sollicitudin pharetra. Fusce semper, neque quis ultricies bibendum, ligula tortor ultricies justo, eget finibus ex mauris vestibulum sapien. Sed eu sapien nibh. Cras efficitur dui est, eget pellentesque libero posuere at. Curabitur efficitur lobortis urna quis dictum. Morbi quis vulputate mi, sed congue dui. In volutpat rhoncus convallis. Quisque non pharetra massa. :).",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9585),
                            ForumId = 3,
                            Title = "What is everyone's favorite other?",
                            UserId = 1
                        },
                        new
                        {
                            PostId = 4,
                            Body = "I liked adrian brodee in this movie but idk who made it. I tried to llok it up but just got something about a petition?",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9587),
                            ForumId = 1,
                            Title = "Who directed 'The Pianist?'",
                            UserId = 3
                        },
                        new
                        {
                            PostId = 5,
                            Body = "",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9589),
                            ForumId = 2,
                            Title = "Biggest game company of all time reports $0 of income for Q2 2025",
                            UserId = 4
                        },
                        new
                        {
                            PostId = 6,
                            Body = "I can believe it, the entire feast I prepared is gone. Who Pudding, Who Roast, even my ice box is nothing but crumbs left. \nThey even took my last can of Who hash... I think im going to be sick ",
                            Date = new DateTime(2024, 11, 6, 20, 21, 36, 305, DateTimeKind.Utc).AddTicks(9590),
                            ForumId = 3,
                            Title = "My home was ransacked last night on christmas Eve",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("RedditClone.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Name = "Wellernaught"
                        },
                        new
                        {
                            UserId = 2,
                            Name = "Thuggonomics"
                        },
                        new
                        {
                            UserId = 3,
                            Name = "ricflair12441"
                        },
                        new
                        {
                            UserId = 4,
                            Name = "PeterPumpkinEater"
                        },
                        new
                        {
                            UserId = 5,
                            Name = "FirstNameBunch0Numbas"
                        },
                        new
                        {
                            UserId = 6,
                            Name = "ReiGaan224"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
