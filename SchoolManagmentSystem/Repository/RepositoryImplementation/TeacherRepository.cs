using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystem.Data;
using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Repository.RepositoryInterfaces;

namespace SchoolManagmentSystem.Repository.RepositoryImplementation
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext context;

        public TeacherRepository(ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }

        public List<Teacher> GetAllTeachers()
        {
            return context.Teachers.Include(t => t.Subjects).ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            return context.Teachers.Include(t => t.Subjects).FirstOrDefault(t => t.Id == id);
        }

        public void AddTeacher(Teacher teacher)
        {

            context.Teachers.Add(teacher);
            context.SaveChanges();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            context.Teachers.Update(teacher);
            context.SaveChanges();
        }

        public void DeleteTeacher(int id)
        {
            var teacher = context.Teachers.Find(id);
            if (teacher != null)
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
        }
    }
}
