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
                //Add new student objects to context to be saved
                _context.Students.Add(new Student { FirstName = "Robert", LastName = "Searle", EmailID = "rsearle@hotmail.com", PhoneNo = "224-456-9800" });
                _context.Students.Add(new Student { FirstName = "Autumn", LastName = "Ellis",  EmailID = "aellis@gmail.com",    PhoneNo = "331-845-7459" });
                _context.Students.Add(new Student { FirstName = "Anna",   LastName = "Searle", EmailID = "asearle@yahoo.com", PhoneNo = "224-326-1562" });
                _context.SaveChanges();
            }

        }//end studentContoller

        public ActionResult Index()
        {
            return View("Views/Index");
        }


        [HttpGet]
        public List<Student> GetAll()
        {
            //reuturn list of student object from context db
            //How do i get this list information into view to display in html table foreach loop
            //Return list data seen as output
            return _context.Students.ToList();
        }

    }//end of controller
}