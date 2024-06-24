using SchoolManagmentSystem.Models.Entities;

namespace SchoolManagmentSystem.Repository.RepositoryInterfaces
{
    public interface ILiteratureRepository
    {
        List<Literature> GetAllLiteratures();
        Literature GetLiteratureById(int id);
        void AddLiterature(Literature literature);
        void UpdateLiterature(Literature literature);
        void DeleteLiterature(int id);
        List<Literature> GetLiteraturesBySubjectId(int subjectId);
    }
}
