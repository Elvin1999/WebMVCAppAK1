using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebMVCAppAK1.Models;

namespace WebMVCAppAK1.Controllers
{
    public class HomeController : Controller
    {
        public string Index55()
        {
            return $"Hello from Index Action";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                     CityId=10,
                      Firstname="Elvin",
                       Lastname="Camalzade"
                },
                new Employee
                {
                    Id=2,
                     CityId=55,
                      Firstname="John",
                       Lastname="Johnlu"
                }
            };

            List<string> cities = new List<string> { "Baku", "Ankara", "Istanbul" };

            var vm = new EmployeeViewModel
            {
                Cities = cities,
                Employees = employees
            };


            return View(vm);
        }

        public IActionResult Index4()
        {

            return Ok();
        }

        public IActionResult Index5()
        {

            return NotFound();
        }

        public IActionResult Index6()
        {
            return BadRequest();
        }

        public IActionResult Index7()
        {
            return Redirect("/home/index");
        }

        public IActionResult Index8()
        {
            return RedirectToAction("index3");
        }

        public JsonResult GetJson()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                     CityId=10,
                      Firstname="Elvin",
                       Lastname="Camalzade"
                },
                new Employee
                {
                    Id=2,
                     CityId=55,
                      Firstname="John",
                       Lastname="Johnlu"
                }
            };
            return Json(employees);
        }
        public JsonResult Index9(int id=-1)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                     CityId=10,
                      Firstname="Elvin",
                       Lastname="Camalzade"
                },
                new Employee
                {
                    Id=2,
                     CityId=55,
                      Firstname="John",
                       Lastname="Johnlu"
                }
            };
            var result = (id == -1) ? employees : employees.Where(e => e.Id == id);
            return Json(result);
        }

        public JsonResult Index10(string name="",int id = -1)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                     CityId=10,
                      Firstname="Elvin",
                       Lastname="Camalzade"
                },
                new Employee
                {
                    Id=2,
                     CityId=55,
                      Firstname="John",
                       Lastname="Johnlu"
                }
            };
            //var result = (id == -1) ? employees : employees.Where(e => e.Id == id);
            var result = employees.Where(e => e.Firstname.Contains(name) || name==String.Empty);
            return Json(result);
        }
    }
}
