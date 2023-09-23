using Microsoft.EntityFrameworkCore;
using MVCNorthwind.Models;
using MVNwin.Models;
using MVNwin.Modelscls;
using NuGet.Protocol.Core.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer("name=NwindConnection"));
builder.Services.AddScoped<RepositoryEmployee>();
builder.Services.AddScoped<RepositoryOrder>();
builder.Services.AddScoped<RepositoryCustomer>();
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
