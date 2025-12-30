using CHO_Saathi.Models;
using CHO_Saathi.ViewModelEntity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*--------------------Sumit start 19-08-25-----------------------*/

// HttpContextAccessor should be registered as singleton using interface
builder.Services.AddHttpContextAccessor();

// Distributed cache for session
builder.Services.AddDistributedMemoryCache();

// Database context
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString"),
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure();
            // sqlOptions.CommandTimeout(180); // Uncomment if needed
        });
});

// Authentication with cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Login";
        options.LogoutPath = "/Login/Login";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(35);
        options.SlidingExpiration = true; // recommended
    });

// Session configuration
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(35);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Response compression
builder.Services.AddResponseCompression(options =>
{
    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});

// CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

/*-----------------------------------------------------------------*/


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// ✅ Handle 404 gracefully using built-in middleware
app.UseStatusCodePagesWithReExecute("/Home/PageNotFound");


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCors("AllowAll");

app.UseRouting();

app.UseResponseCompression();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
