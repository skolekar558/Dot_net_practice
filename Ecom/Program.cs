
using Ecom.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);




var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));





// Add services to the container.
builder.Services.AddControllersWithViews();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movie}/{action=Index}/{id?}");

app.Run();
