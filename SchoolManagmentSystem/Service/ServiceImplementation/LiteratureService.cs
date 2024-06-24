using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Repository.RepositoryInterfaces;
using SchoolManagmentSystem.Service.ServiceInterfaces;

namespace SchoolManagmentSystem.Service.ServiceImplementation
{
    public class LiteratureService : ILiteratureService
    {
        private readonly ILiteratureRepository literatureRepository;

        public LiteratureService(ILiteratureRepository literaturerepository)
        {
            literatureRepository = literaturerepository;
        }

        public List<Literature> GetLiteraturesBySubjectId(int subjectId)
        {
            return literatureRepository.GetLiteraturesBySubjectId(subjectId);
        }
    }
}
