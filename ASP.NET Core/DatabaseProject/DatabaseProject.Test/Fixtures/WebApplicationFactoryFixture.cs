using DatabaseProject.DbContexts;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DatabaseProject.Test.Fixtures
{
    public class WebApplicationFactoryFixture : IAsyncLifetime
    {
        public HttpClient Client { get; private set; }
        public int InitializeStudentsCount { get; set; } = 3;
        private WebApplicationFactory<Program> _factory;
        private const string _connectionString = "Server=localhost\\SQLEXPRESS;Database=IntegrationTest;Trusted_Connection=True;TrustServerCertificate=True";

        public WebApplicationFactoryFixture()
        {
            _factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.RemoveAll(typeof(DbContextOptions<SchoolDbContext>));
                    services.AddDbContext<SchoolDbContext>(options =>
                    {
                        options.UseSqlServer(_connectionString);
                    });
                });
            });
            Client = _factory.CreateClient();
        }

        async Task IAsyncLifetime.InitializeAsync()
        {
            using (var scope = _factory.Services.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var cntx = scopedServices.GetRequiredService<SchoolDbContext>();
                await cntx.Database.EnsureCreatedAsync();
                await cntx.Students.AddRangeAsync(DataFixture.GetStudents(InitializeStudentsCount));
                await cntx.SaveChangesAsync();
            }
        }

        async Task IAsyncLifetime.DisposeAsync()
        {
            using (var scope = _factory.Services.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var cntx = scopedServices.GetRequiredService<SchoolDbContext>();
                await cntx.Database.EnsureDeletedAsync();
            }
        }
    }
}

