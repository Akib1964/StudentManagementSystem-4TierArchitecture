using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Business;
using StudentManagementSystem.Entities;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _service;
        public StudentController(StudentService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var student = _service.GetAllStudents();
            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _service.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var exist = _service.GetStudentById(id);
            if (exist == null)
            {
                return NotFound();
            }
            return View(exist);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _service.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }
        public IActionResult Delete(int id)
        {
            _service.DeleteStudent(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var exist = _service.GetStudentById(id);
            if (exist == null) return NotFound();
            return View(exist);
        }
    }
}
