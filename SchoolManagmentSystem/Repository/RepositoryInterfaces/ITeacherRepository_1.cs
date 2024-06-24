using SchoolManagmentSystem.Models.Entities;

namespace SchoolManagmentSystem.Repository.RepositoryInterfaces
{
    public interface ITeacherRepository
    {
       
            List<Teacher> GetAllTeachers();
            Teacher GetTeacherById(int id);
            void AddTeacher(Teacher teacher);
            void UpdateTeacher(Teacher teacher);
            void DeleteTeacher(int id);
        
    }
}
