using DatabaseProject.Models;
using System.Net;
using System.Net.Http.Json;

namespace DatabaseProject.Test.Controllers
{
    public class EnvironmentTest : IClassFixture<WebApplicationFactoryFixture>
    {
        private WebApplicationFactoryFixture _factory;
        public EnvironmentTest(WebApplicationFactoryFixture factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task OnGetStudents_WhenExecuteController_ShouldReturnTheExpectedStudent()
        {
            // Arrange                        

            // Act
            var response = await _factory.Client.GetAsync(HttpHelper.Urls.GetAllStudents);
            var result = await response.Content.ReadFromJsonAsync<List<Student>>();

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            result.Count.Should().Be(_factory.InitializeStudentsCount);
            result.Should().BeEquivalentTo(DataFixture.GetStudents(_factory.InitializeStudentsCount), options =>
                options.Excluding(t => t.StudentId)
            );
        }

        [Fact]
        public async Task OnAddStudent_WhenExecuteController_ShouldStoreInDb()
        {
            // Arrange
            var newStudent = DataFixture.GetStudent(true);

            // Act            
            var request = await _factory.Client.PostAsync(HttpHelper.Urls.AddStudent, HttpHelper.GetJsonHttpContent(newStudent));
            var response = await _factory.Client.GetAsync($"{HttpHelper.Urls.GetStudent}/{_factory.InitializeStudentsCount + 1}");
            var result = await response.Content.ReadFromJsonAsync<Student>();

            // Assert
            request.StatusCode.Should().Be(HttpStatusCode.OK);
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            result.FirstName.Should().Be(newStudent.FirstName);
            result.LastName.Should().Be(newStudent.LastName);
            result.Address.Should().Be(newStudent.Address);
            result.BirthDay.Should().Be(newStudent.BirthDay);
        }
    }
}
