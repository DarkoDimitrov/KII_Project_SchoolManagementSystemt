using SchoolManagmentSystem.Models.Entities;

namespace SchoolManagmentSystem.Service.ServiceInterfaces
{
    public interface ILiteratureService
    {
        List<Literature> GetLiteraturesBySubjectId(int subjectId);
    }
}
