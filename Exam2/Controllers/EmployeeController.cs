using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam2.data;

namespace Exam2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeContext context = new EmployeeContext();
            vm v = new vm();
            List<Department> d = (from x in context.Department1 select x).ToList();

           
            return View("Index" , v);
        }
        public IActionResult Index1()
        {

            return View("NewEmployee");
        }

        public IActionResult saveEmployee(Employee e)
        {
            EmployeeContext context = new EmployeeContext();
            context.Employee1.Add(e);
            context.SaveChanges();
            return View("NewEmployee");
        }
    }
}
