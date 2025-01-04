using DatabaseProject.Models;

namespace DatabaseProject.Services
{
    public interface IStudentService
    {
        Task<bool> AddStudentAsync(Student newStudent);
        Task<bool> DeleteStudentAsync(int id);
        Task<bool> EditStudentAsync(Student editStudent);
        Task<Student> GetStudentAsync(int id);
        Task<List<Student>> GetStudentsAsync();
    }
}
