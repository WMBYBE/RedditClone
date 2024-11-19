using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RedditClone.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();
builder.Services.AddSession();


builder.Services.AddDbContext<ForumDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("ForumContext")));
builder.Services.AddSession(options =>
{
    // change idle timeout to 5 minutes - default is 20 minutes
    options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
    options.Cookie.HttpOnly = false;     // default is true
    options.Cookie.IsEssential = true;   // default is false
});


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();
app.UseSession();




app.UseAuthentication();
app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Forums",
    areaName: "Forums",
    pattern: "Forums/{controller=Forum}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "Users",
    areaName: "Users",
    pattern: "Users/{controller=User}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
