using Microsoft.AspNetCore.Mvc;
using Employee.Models;
using Employee.Data;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var employees = _db.Employees.ToList();
            return View(employees);
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
            public IActionResult CreateEmployee(EmployeesEntity employee){
        _db.Employees.Add(employee);
        _db.SaveChanges();

        return RedirectToAction("Index");
    }
    }


    }
