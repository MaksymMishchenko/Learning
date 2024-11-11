using DatabaseProject.DbContexts;
using DatabaseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProject.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolDbContext _context;
        public StudentService(SchoolDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddStudentAsync(Student newStudent)
        {
            _context.Students.Add(newStudent);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student is null)
            {
                return false;
            }
            _context.Students.Remove(student);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> EditStudentAsync(Student editStudent)
        {
            _context.Update(editStudent);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<Student> GetStudentAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
