using PracticalCore20.Models;

namespace PracticalCore20.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Students>
    {
        Task<Students> GetStudentById(int studentId);
    }
}
