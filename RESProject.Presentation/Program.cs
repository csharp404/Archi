using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RESProject.DataAccess.Data;
using RESProject.Repositories.Entities;
using RESProject.Repositories.Entities.AddressRepo;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MyDbContext>();
builder.Services.AddDbContext<MyDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DBCS")));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepositoryRoom, RepositoryRoom>();
builder.Services.AddScoped<IRepositoryRealES, RepositoryRealES>();
builder.Services.AddScoped<IRepositoryAddress, RepositoryAddress>();
builder.Services.AddScoped<IRepositoryRealESFeature, RepositoryRealESFeature>();
builder.Services.AddScoped<IRepositoryRealESImages, RepositoryRealESImages>();


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
