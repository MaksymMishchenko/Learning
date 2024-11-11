using DatabaseProject.Models;

namespace DatabaseProject.Services
{
    public class StudentService : IStudentService
    {
        public Task<bool> AddStudentAsync(Student newStudent)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditStudentAsync(Student editStudent)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetStudentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
