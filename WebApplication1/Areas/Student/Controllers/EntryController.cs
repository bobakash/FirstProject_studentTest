using Microsoft.AspNetCore.Mvc;
using StudentEntity;
using StudentInterface;

namespace WebApplication1.Areas.Student.Controllers
{[Area("Student")]
    public class EntryController : Controller
    {
        public readonly IStudent _student;
        public EntryController(IStudent student)
        { 
        _student = student;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResponse AddStudent(StudentEntity.Student student)
        {
           return _student.AddStudent(student);
        }
    }
}
