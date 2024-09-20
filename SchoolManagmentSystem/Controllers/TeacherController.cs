using Microsoft.AspNetCore.Mvc;
using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Repository.RepositoryInterfaces;
using SchoolManagmentSystem.Service.ServiceInterfaces;

namespace SchoolManagmentSystem.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService;

        public TeacherController(ITeacherService teachersservice)
        {
            teacherService = teachersservice;
        }
        [HttpGet]
        public IActionResult ListTeachers()
        {
            var teachers = teacherService.GetAllTeachers();
            return View(teachers);
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var teacher = teacherService.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

       

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                teacherService.AddTeacher(teacher);
                return RedirectToAction(nameof(ListTeachers));
            }
            return View(teacher);
        }


    }
}
