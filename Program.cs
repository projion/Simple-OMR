using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Simple_OMR.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

            //var connectionString = builder.Configuration.GetConnectionString("DBConnection");
            //builder.Services.AddDbContext<DemoBuffer>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContextPool<AppDbContext>(options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
                });
builder.Services.AddScoped<IDemoBufferRepository, SQLDemoBufferRepository>();
//below services used for login
//Password Complexity Options
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                {
                    options.Password.RequiredLength = 6;
                    options.Password.RequiredUniqueChars = 2;
                    options.Password.RequireDigit = false;
                    options.Password.RequireUppercase = false;
                }).AddEntityFrameworkStores<AppDbContext>();
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

//            //Password Complexity Options
//builder.Services.Configure<IdentityOptions>(options =>
//    {
//        options.Password.RequiredLength = 6;
//        options.Password.RequiredUniqueChars = 2;
//        options.Password.RequireUppercase = false;
//    });

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
            //Configured middleware for login
app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
