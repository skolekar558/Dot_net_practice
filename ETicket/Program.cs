using ETicket.Data;
using ETicket.Data.Repositories;
using ETicket.Data.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
// Add services to the container.
builder.Services.AddScoped<IActorRepository, ActorRepository>();
builder.Services.AddScoped<IActorsService, ActorsService>();
builder.Services.AddScoped<IProducerRepository, ProducerRepository>();
builder.Services.AddScoped<IProducerService, ProducerService>();
builder.Services.AddScoped<ICinemaService, CinemaService>();
builder.Services.AddScoped<ICinemaRepository, CinemaRepository>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

var app = builder.Build();

//seeding database
using (var serviceScope = app.Services.CreateScope())
{
    var Context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    AppDbInitializer.Seed(Context);
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
