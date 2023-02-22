using LeaveManagement.Configuration;
using LeaveManagement.Configuration.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Repositories;
using LeaveManagement.Serivices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)

    /* <Implemented by me> Roles addition only */
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

//<Implemented by me>
builder.Services.AddAutoMapper(typeof(MapperConfig));

//AddTransient -> gave new copy of serviecs every time it injected/needed  (DB concurrency issue) 
//AddSingleton -> only single instance of serviecs every time it injected/needed  (DB concurrency issue) 
//AddSingleton -> (Transient + singleton) new instance of serviecs every time it injected/needed but auto destroyed if connec.close

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();

// Email servic Configuration -> (ip or servername , defaultPort , From mailAddress)
builder.Services.AddTransient<IEmailSender>(s => new EmailSender("localhost", 25 , "no-reply@leavemanagement.com"));

// Leave Allocation To Employees by admin
builder.Services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();


var app = builder.Build();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
