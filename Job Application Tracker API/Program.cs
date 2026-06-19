using Job_Application_Tracker_API.Data;
using Job_Application_Tracker_API.Helpers;
using Job_Application_Tracker_API.Services.Contracts;
using Job_Application_Tracker_API.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<JwtHelper>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

app.Run();