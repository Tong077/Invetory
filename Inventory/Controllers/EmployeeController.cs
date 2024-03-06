using Inventory.Models;
using Inventory.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var results = _service.GetAll();
            return View(await results);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Store(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View("Create",employee);
            }
            if (await _service.Create(employee))
            {
                return RedirectToAction("Index");
            }
            return View("Create",employee);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int EmployeeId) 
        {
            var results = await _service.GetById(EmployeeId);
            return View(results);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",employee);
            }
            if (await _service.Update(employee))
            {
                return RedirectToAction("Index");
            }
            return View("Edit",employee);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int EmployeeId)
        {
            var results = await _service.GetById(EmployeeId);
                return View(results);
        }
        [HttpPost]
        public async Task<IActionResult> Destroy(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", employee);
            }
            if(await _service.Delete(employee))
            {
                return RedirectToAction("Index");
            }
            return View("Index", employee);
        }
    }
}
