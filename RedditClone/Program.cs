using Microsoft.EntityFrameworkCore;
using RedditClone.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ForumDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("ForumContext")));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Forums",
    areaName: "Forums",
    pattern: "Forums/{controller=Forum}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "Posts",
    areaName: "Posts",
    pattern: "Posts/{controller=Post}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
