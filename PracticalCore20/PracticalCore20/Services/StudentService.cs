using PracticalCore20.Interfaces;
using PracticalCore20.Models;

namespace PracticalCore20.Services
{
    public class StudentService : IStudentService
    {
        public IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task AddStudent(Students students)
        {
            var student = new Students
            {
                Email = students.Email,
                StudentName = students.StudentName,
                Phone = students.Phone,
            };

            _unitOfWork.StudentRepository.Add(students);
            await _unitOfWork.CommitAsync();
        }


        public async Task<IEnumerable<Students>> GetAll()
            => await _unitOfWork.StudentRepository.GetAll();
    }
}
