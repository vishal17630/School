using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;
using System.Diagnostics;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentDBcontext _studentDBContext;

        public HomeController(ILogger<HomeController> logger, StudentDBcontext studentDBcontext )
        {
            _logger = logger;
            _studentDBContext = studentDBcontext;
        }

        public IActionResult Index()
        {
            return View(_studentDBContext.StudentsDate);

        }

      
        [HttpPost]
        public IActionResult Post(Student Details)
        {
            //add Student Details to the studentDBContext
            _studentDBContext.StudentsDate.Add(Details);
            _studentDBContext.SaveChanges();
            return RedirectToAction("StudentDetails");
        }

        
        public IActionResult Update(int id)
        {
            var data = _studentDBContext.StudentsDate.FirstOrDefault(a => a.StudentId == id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update_Post(Student student)
        {
            _studentDBContext.StudentsDate.Update(student);
            _studentDBContext.SaveChanges();
            return RedirectToAction("StudentDetails");
        }
        public IActionResult Delete(int id)
        {
            var data = _studentDBContext.StudentsDate.FirstOrDefault(a => a.StudentId == id);
            _studentDBContext.StudentsDate.Remove(data);
            _studentDBContext.SaveChanges();
            return RedirectToAction("StudentDetails");
        }


        public IActionResult Create()
        {

            return View();
        }

        public IActionResult StudentDetails()
        {
            var StudentsDate = _studentDBContext.StudentsDate.ToList();

            return View(StudentsDate);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

