using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(p => {
        p.LoginPath = "/auth/login";
        p.ExpireTimeSpan = TimeSpan.FromDays(30);
    });

builder.Services.AddDbContext<BDSContext>(p => 
    p.UseSqlServer(builder.Configuration.GetConnectionString("QLBDS")));
builder.Services.AddMvc();

var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();