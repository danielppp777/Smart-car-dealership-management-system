using System.Data; 
using Microsoft.EntityFrameworkCore;
using System;
using YourNamespace.Data;

var builder = WebApplication.CreateBuilder(args);

// ������������ �� �������� ��� ������ �����
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ������ � ����� ������, ���� �������� �� ����������
builder.Services.AddControllersWithViews(); // ��� ��������� MVC �����

var app = builder.Build();

// ����� �� ���������� (Development) - �������� �� ������� �����������
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// ��������� �� ��������� (�������� HTTPS)
app.UseHttpsRedirection();
app.UseStaticFiles();

// ������������ �� �������������
app.UseRouting();

app.UseAuthorization();

// ��������� �� �������� �� ��������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

