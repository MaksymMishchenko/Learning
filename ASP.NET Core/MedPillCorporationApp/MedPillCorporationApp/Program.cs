using MedPillCorporationApp.Interfaces;
using MedPillCorporationApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(opts => opts.EnableEndpointRouting = false);

// �������� ������ ����������
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// ��������� SqlServer �� � ����� ��������� �������� ������
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
// ������ ����, � ����� ��������� ����������, ���� ������ ��� ����� �������� � ���� �����
builder.Services.AddTransient<IPillRepository, PillRepository>();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    var repository = new PillRepository(context);
    repository.EnsurePopulated();
}

app.UseStatusCodePages();
app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();

app.Run();
