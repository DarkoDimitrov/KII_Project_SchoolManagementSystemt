using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Repository.RepositoryInterfaces;
using SchoolManagmentSystem.Service.ServiceInterfaces;

namespace SchoolManagmentSystem.Service.ServiceImplementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentrepository)
        {
            studentRepository = studentrepository;
        }

        public List<Student> GetAllStudents()
        {
            return studentRepository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return studentRepository.GetStudentById(id);
        }

        public void AddStudent(Student student)
        {
            studentRepository.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            studentRepository.UpdateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            studentRepository.DeleteStudent(id);
        }
    }
}
