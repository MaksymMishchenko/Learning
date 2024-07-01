using MedPillCorporationApp.Interfaces;
using MedPillCorporationApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// добуваємо стрічку підключення
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// підключаємо SqlServer та в якості параметру передаємо стрічку
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
// Додаємо клас, в якості реалізації інтерфейсу, який отримує дані через контекст з бази даних
builder.Services.AddTransient<IPillRepository, PillRepository>();
var app = builder.Build();



app.Run();
