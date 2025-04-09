using Microsoft.AspNetCore.Mvc;
using UE_GPA.Models;
using UE_GPA.Data;

namespace UE_GPA.Controllers
{
    public class StudentMarksController : Controller
    {
        private readonly AppDbContext _context;

        public StudentMarksController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(StudentMark mark)
        {
            if (ModelState.IsValid)
            {
                float totalMarks = mark.Marks1 + mark.Marks2 + mark.Marks3 + mark.Marks4 + mark.Marks5;
                float average = totalMarks / 5;
                mark.GPA = average / 20; // Adjust this formula as needed

                _context.StudentMarks.Add(mark);
                _context.SaveChanges();

                ViewBag.Message = "GPA Calculated and Saved Successfully!";
                return View("Result", mark);
            }

            return View(mark);
        }

        public IActionResult Result()
        {
            return View();
        }
    }
}
