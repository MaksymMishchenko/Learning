using MedPillCorporationApp.Interfaces;
using MedPillCorporationApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// �������� ������ ����������
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// ��������� SqlServer �� � ����� ��������� �������� ������
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
// ������ ����, � ����� ��������� ����������, ���� ������ ��� ����� �������� � ���� �����
builder.Services.AddTransient<IPillRepository, PillRepository>();
var app = builder.Build();



app.Run();
