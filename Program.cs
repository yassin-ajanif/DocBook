using MedicalAppointement.Models;
using MedicalAppointementBusinessLayer;
using MedicalAppointementDataLayer;
using MedicalAppointementDataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedLayer.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MedicalCabinetContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ItestService,TestService>();
builder.Services.AddScoped<ItestRepository,TestRepository>();

builder.Services.AddTransient(typeof(ICrud<>), typeof(MainRepository<>));

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
