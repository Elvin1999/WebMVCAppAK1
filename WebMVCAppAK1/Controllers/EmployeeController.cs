using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using WebMVCAppAK1.Entities;
using WebMVCAppAK1.Models;

namespace WebMVCAppAK1.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> employees = new List<Employee>
        {
             new Employee
             {
                 Id=1,
                 Firstname="Arif",
                  Lastname="Arifli",
                  CityId=10
             },
             new Employee
             {
                 Id=2,
                  Firstname="Leyla",
                  Lastname="Mammadova",
                  CityId=55
             }
        };
        public IActionResult Index()
        {
            var vm = new EmployeeListViewModel
            {
                Employees = employees
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = employees.FirstOrDefault(e => e.Id == id);
            employees.Remove(item);
            return RedirectToAction("index");
        }



        [HttpGet]
        public IActionResult Add()
        {
            var viewmodel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Baku", Value = "10" },
                    new SelectListItem { Text = "Sheki", Value = "55" },
                    new SelectListItem { Text = "Sumqayit", Value = "50" },
                }
            };
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                employees.Add(model.Employee);
                return RedirectToAction("index"); 
            }
            else
            {
                model.Cities = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Baku", Value = "10" },
                    new SelectListItem { Text = "Sheki", Value = "55" },
                    new SelectListItem { Text = "Sumqayit", Value = "50" },
                };
                return View(model);
            }
        }
    }
}
