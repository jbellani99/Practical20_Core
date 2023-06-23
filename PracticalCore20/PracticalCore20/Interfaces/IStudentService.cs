using PracticalCore20.Models;

namespace PracticalCore20.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Students>> GetAll();
        Task AddStudent(Students student);
    }
}
