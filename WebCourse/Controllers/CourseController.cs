using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCourse.Models;

namespace WebCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course(){Cid = 1,CName="Sanju",CFee = 15000,Technology = "Java",CStartDate = new DateTime(day:09,month:11,year:2000),CEndDate = new DateTime(day:09,month:11,year:2001),},
            new Course(){Cid = 2,CName="preetham",CFee = 25000,Technology = "Python",CStartDate = new DateTime(day:09,month:06,year:2001),CEndDate = new DateTime(day:09,month:11,year:2001),},
            new Course(){Cid = 3,CName="Praneeth",CFee = 35000,Technology = "Data Engineering",CStartDate = new DateTime(day:09,month:03,year:2001),CEndDate = new DateTime(day:06,month:06,year:2001)}
        };

        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course course) 
        { 
            if(ModelState.IsValid)
            {
                courses.Add(course);
                return RedirectToAction("index");
            }
            return View(course);
        }
    }
}