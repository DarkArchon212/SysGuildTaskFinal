using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sysguildtask.Models;

namespace sysguildtask.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]

    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
            if (_context.Students.Count() == 0)
            {
                _context.Students.Add(new Student { FirstName = "Robert", LastName = "Searle", EmailID = "rsearle@hotmail.com", PhoneNo = "224-456-9800" });
                _context.Students.Add(new Student { FirstName = "Autumn", LastName = "Ellis",  EmailID = "aellis@gmail.com",    PhoneNo = "331-845-7459" });
                _context.Students.Add(new Student { FirstName = "Anna",   LastName = "Searle", EmailID = "asearle@yahoo.com", PhoneNo = "224-326-1562" });
                _context.SaveChanges();
            }

        }//end studentContoller

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        /*
        [HttpGet("{FirstName}", Name = "GetStudent")]
        public IActionResult GetByName(String name)
        {
            var stud = _context.Students.Find(name);
            if(stud == null)
            {
                return NotFound();
            }
            return Ok(stud);
        }
        */
        


    }//end of controller
}