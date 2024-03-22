using Microsoft.EntityFrameworkCore;
using Mission11_Michael_Hutchings.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add our database connection using the context file
builder.Services.AddDbContext<BookstoreContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:BookstoreConnections"]);
});

// Add our repository pattern
builder.Services.AddScoped<IBookstoreRepository, EFBookstoreRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Having the URL expect a pageNum so that it looks better in the URL
app.MapControllerRoute(
    "pagination",
    "Projects/{pageNum}",
    new { Controller = "Home", action = "Index" }
    );

app.MapDefaultControllerRoute();
app.Run();
