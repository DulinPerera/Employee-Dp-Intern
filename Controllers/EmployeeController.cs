using Microsoft.AspNetCore.Mvc;
using Employee.Models;
using Employee.Data;
using Microsoft.EntityFrameworkCore;

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

    [HttpGet]
        public async Task<IActionResult> Edit(int id) // Corrected method signature
        {
            var employee = await _db.Employees.FirstOrDefaultAsync(x => x.Id == id); // Corrected query
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // Add a [HttpPost] method for saving the edited employee data
        [HttpPost]
        public async Task<IActionResult> Edit(EmployeesEntity employee)
        {
            if (ModelState.IsValid)
            {
                _db.Update(employee);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
 



    }
    }
