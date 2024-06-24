using Microsoft.AspNetCore.Mvc;
using SchoolManagmentSystem.Models.Entities;
using SchoolManagmentSystem.Service.ServiceInterfaces;

namespace SchoolManagmentSystem.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentservice)
        {
            studentService = studentservice;
        }

        [HttpGet]
        public IActionResult ListStudents()
        {
            var students = studentService.GetAllStudents();
            return View(students);
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var student = studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                studentService.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var student = studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                studentService.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var student = studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
