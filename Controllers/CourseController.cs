using basics.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course();

        kurs.Id = 1;
        kurs.Title = "Asp.NET Kursu";


        return View(kurs);
    }
    public IActionResult List()
    {
        var kurslar = new List<Course>(){
            new Course(){Id=1,Title= "Asp.Net Kursu",Image="1.jpg",Description= "Guzel"},
            new Course(){Id=2,Title= "Django Kursu",Image="2.jpg",Description= "Guzel"},
            new Course(){Id=3,Title= "C# Kursu",Image="3.jpg",Description= "Guzel"},
            new Course(){Id=4,Title="Java Script Kursu",Image="4.jpg",Description= "Guzel"}
        };

        return View(kurslar);
    }

}

