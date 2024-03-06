using Microsoft.EntityFrameworkCore;
using Inventory.Data;
using Microsoft.Extensions.Options;
using Inventory.Repository;
using Inventory.Repositoy;

var builder = WebApplication.CreateBuilder(args);
//use ofr configure service


builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IEmployeeService, EmployeeServiceImpl>();
builder.Services.AddScoped<IProductService, ProductServiceImpl>();
builder.Services.AddScoped<ICategoryService, CategoryServiceImpl>();
//----------------------------------------------------------------//
var connetionString = builder.Configuration.GetConnectionString("MyConnection");
builder.Services.AddDbContext<EntityDbContext>( options =>
{
    options.UseSqlServer(connetionString );
});

var app = builder.Build();
//configure Middleware or Request Pipelines
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();
