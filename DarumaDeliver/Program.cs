using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DarumaDeliver.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DarumaDeliverDbContextConnection") ?? throw new InvalidOperationException("Connection string 'DarumaDeliverDbContextConnection' not found.");

builder.Services.AddDbContext<DarumaDeliverDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<DarumaDeliverUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DarumaDeliverDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseAuthentication();;

app.UseAuthorization();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
