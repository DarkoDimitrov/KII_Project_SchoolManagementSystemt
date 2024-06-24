using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Repository.RepositoryInterfaces;
using SchoolManagmentSystem.Service.ServiceInterfaces;

namespace SchoolManagmentSystem.Service.ServiceImplementation
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository teacherRepository;

        public TeacherService(ITeacherRepository teacherrepository)
        {
            teacherRepository = teacherrepository;
        }

        public List<Teacher> GetAllTeachers()
        {
            return teacherRepository.GetAllTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            return teacherRepository.GetTeacherById(id);
        }

        public void AddTeacher(Teacher teacher)
        {
            teacherRepository.AddTeacher(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            teacherRepository.UpdateTeacher(teacher);
        }

        public void DeleteTeacher(int id)
        {
            teacherRepository.DeleteTeacher(id);
        }
    }
}
