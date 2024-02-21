using SchoolManagement.Domain.Models;

namespace SchoolManagement.Domain.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> Get();

        Task<Student> GetById(int id);

        Task Add(Student student);

        Task Update(int Id, Student student);

        Task Delete(int id);
    }
}
