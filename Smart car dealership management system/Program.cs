using System.Data; 
using Microsoft.EntityFrameworkCore;
using System;
using YourNamespace.Data;

var builder = WebApplication.CreateBuilder(args);

// Конфигурация на връзката към базата данни
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Добави и други услуги, като например за контролери
builder.Services.AddControllersWithViews(); // ако използваш MVC модел

var app = builder.Build();

// Среда за разработка (Development) - добавяне на полезни инструменти
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Настройки за сигурност (например HTTPS)
app.UseHttpsRedirection();
app.UseStaticFiles();

// Конфигурация на маршрутизация
app.UseRouting();

app.UseAuthorization();

// Настройка на пътеките за заявките
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

