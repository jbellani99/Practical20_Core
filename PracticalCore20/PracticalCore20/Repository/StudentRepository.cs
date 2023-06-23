using Microsoft.EntityFrameworkCore;
using PracticalCore20.Interfaces;
using PracticalCore20.Models;

namespace PracticalCore20.Repository
{
    public class StudentRepository : GenericRepository<Students>, IStudentRepository
    {
        private readonly AppDbContext _dbContext;

        public StudentRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Students> GetStudentById(int id)
        {
            return await _dbContext.Students.FindAsync(id);

        }
    }
}
