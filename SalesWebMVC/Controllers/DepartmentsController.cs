using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = [];
            departments.Add(new Department { Id = 1, Name = "Legos" });
            departments.Add(new Department { Id = 2, Name = "Nerfs" });

            return View(departments);
        }
    }
}
