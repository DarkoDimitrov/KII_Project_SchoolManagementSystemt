using SchoolManagmentSystem.Models.Entities;

namespace SchoolManagmentSystem.Models.ViewModels
{
    public class SubjectDetailsViewModel
    {
        public Subject Subject { get; set; }
        public List<Literature> Literatures { get; set; }
    }
}
