using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Models.ViewModels;

namespace SchoolManagmentSystem.Service.ServiceInterfaces
{
    public interface ISubjectService
    {
        
        List<Subject> GetAllSubjects();

        
        Subject GetSubjectById(int id);

       
        void AddSubject(Subject subject);

        
        void UpdateSubject(Subject subject);

        
        void DeleteSubject(int id);
        public SubjectDetailsViewModel GetSubjectDetails(int id);
    }
}
