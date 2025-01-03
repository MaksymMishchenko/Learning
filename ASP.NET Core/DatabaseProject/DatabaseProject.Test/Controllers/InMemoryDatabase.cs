﻿using DatabaseProject.DbContexts;
using DatabaseProject.Models;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace DatabaseProject.Test.Controllers
{
    public class InMemoryDatabase
    {
        private WebApplicationFactory<Program> _factory;
        public InMemoryDatabase()
        {
            _factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
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
        }

        [Fact]
        public async Task OnGetStudents_WhenExecuteApi_ShouldReturnExpectedStudents()
        {
            // Arrange            

            using (var scope = _factory.Services.CreateScope())
            {
                var scopeService = scope.ServiceProvider;
                var dbContext = scopeService.GetRequiredService<SchoolDbContext>();

                // потрібно переконатися що база видалена та створена
                dbContext.Database.EnsureDeleted();
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

            var client = _factory.CreateClient();

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

        [Fact]
        public async Task OnAddStudent_WhenExecuteController_ShouldStoreInDb()
        {
            // Arrange            
            using (var scope = _factory.Services.CreateScope())
            {
                var scopeService = scope.ServiceProvider;
                var dbContext = scopeService.GetRequiredService<SchoolDbContext>();

                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
            }
            var client = _factory.CreateClient();

            var newStudent = new Student
            {
                FirstName = "name1",
                LastName = "family1",
                Address = "address1",
                BirthDay = new DateTime(1989, 07, 09)
            };

            var httpContent = new StringContent(JsonSerializer.Serialize(newStudent), Encoding.UTF8, "application/json");

            // Act
            var request = await client.PostAsync(HttpHelper.Urls.AddStudent, httpContent);
            var response = await client.GetAsync(HttpHelper.Urls.GetAllStudents);
            var result = await response.Content.ReadFromJsonAsync<List<Student>>();

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            request.StatusCode.Should().Be(HttpStatusCode.OK);

            result.Count.Should().Be(1);
            result[0].FirstName.Should().Be("name1");
            result[0].LastName.Should().Be("family1");
            result[0].Address.Should().Be("address1");
            result[0].BirthDay.Should().Be(new DateTime(1989, 07, 09));
        }
    }
}
