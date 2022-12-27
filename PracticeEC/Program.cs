 using Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//controller setting
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

//to serve static file
app.UseStaticFiles();

//routing and controller setting
app.UseRouting();
app.MapControllers();

//start app
app.Run();
