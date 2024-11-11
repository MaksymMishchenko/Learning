using DatabaseProject.DbContexts;
using DatabaseProject.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Net;
using System.Net.Http.Json;

namespace DatabaseProject.Test.Controllers
{
    public class InMemoryDatabase
    {
        [Fact]
        public async Task OnGetStudents_WhenExecuteApi_ShouldReturnExpectedStudents()
        {
            // Arrange
            var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.RemoveAll(typeof(DbContextOptions<SchoolDbContext>));
                    services.AddDbContext<SchoolDbContext>(options =>
                    {
                        options.UseInMemoryDatabase("test");
                    });
                });
            });

            using (var scope = factory.Services.CreateScope())
            {
                var scopeService = scope.ServiceProvider;
                var dbContext = scopeService.GetRequiredService<SchoolDbContext>();

                // потрібно переконатися що база існує
                dbContext.Database.EnsureCreated();
                dbContext.Students.Add(new Student
                {
                    FirstName = "name1",
                    LastName = "family1",
                    Address = "address1",
                    BirthDay = new DateTime(1989, 07, 09)
                });
                dbContext.SaveChanges();
            }

            var client = factory.CreateClient();

            // Act
            var response = await client.GetAsync(HttpHelper.Urls.GetAllStudents);
            var result = await response.Content.ReadFromJsonAsync<List<Student>>();

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            result.Count.Should().Be(1);
            result[0].FirstName.Should().Be("name1");
            result[0].LastName.Should().Be("family1");
            result[0].Address.Should().Be("address1");
            result[0].BirthDay.Should().Be(new DateTime(1989, 07, 09));
        }
    }
}
