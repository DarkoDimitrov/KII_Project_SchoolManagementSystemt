using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystem.Data;
using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Repository.RepositoryInterfaces;

namespace SchoolManagmentSystem.Repository.RepositoryImplementation
{
    public class LiteratureRepository : ILiteratureRepository
    {
        private readonly ApplicationDbContext context;

        public LiteratureRepository(ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }

        public List<Literature> GetAllLiteratures()
        {
            return context.Literatures.ToList();
        }
        public IEnumerable<Literature> GetAllLiteraturesBySubjectId(int subjectId)
        {
            return context.Literatures
                           
                           .ToList();
        }

        public Literature GetLiteratureById(int id)
        {
            return context.Literatures.Find(id);
        }

        public void AddLiterature(Literature literature)
        {

            context.Literatures.Add(literature);
            context.SaveChanges();
        }

        public void UpdateLiterature(Literature literature)
        {
            context.Literatures.Update(literature);
            context.SaveChanges();
        }

        public void DeleteLiterature(int id)
        {
            var literature = context.Literatures.Find(id);
            if (literature != null)
            {
                context.Literatures.Remove(literature);
                context.SaveChanges();
            }
        }
        public List<Literature> GetLiteraturesBySubjectId(int subjectId)
        {
            return context.Set<Literature>().Where(l => l.Subject.Id == subjectId).ToList();
        }
    }
}
