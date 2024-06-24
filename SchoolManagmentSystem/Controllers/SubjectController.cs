using Microsoft.AspNetCore.Mvc;
using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Repository.RepositoryInterfaces;
using SchoolManagmentSystem.Service.ServiceImplementation;
using SchoolManagmentSystem.Service.ServiceInterfaces;

namespace SchoolManagmentSystem.Controllers
{
    [Route("/")]
    [ApiController]
    public class SubjectsController : Controller
    {
        private readonly ISubjectService _subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        [HttpGet]
        public IActionResult ListSubjects()
        {
            var subjects = _subjectService.GetAllSubjects();
            return View(subjects);
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var subject = _subjectService.GetSubjectDetails(id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }
        [HttpGet ("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNew(Subject subject)
        {
            if (ModelState.IsValid)
            {
                _subjectService.AddSubject(subject);
                return RedirectToAction(nameof(ListSubjects));
            }
            return View(subject);
        }

        
    }
}
