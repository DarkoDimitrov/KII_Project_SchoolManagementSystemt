using SchoolManagmentSystem.Models.Entities;

namespace SchoolManagmentSystem.Service.ServiceInterfaces
{
    public interface ITeacherService
    {
        List<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);
    }
}
