using Inventory.Models;
using Inventory.Repositoy;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var results = await _service.GetAll();
            return View(results);
        }
        [HttpGet]

        public IActionResult Create() 
        { 
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Store(Categories categories)
        {
            if(!ModelState.IsValid)
            {
                return View("Create",categories);
            }
            if(await _service.Create(categories)) 
            {
                return RedirectToAction("Index");
            }
            return View("Create",categories);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int CategoryId)
        {
           var result = await _service.Get(CategoryId);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Categories categories)
        {
            if(!ModelState.IsValid)
            {
                return View("Edit", categories);
            }
            if (await _service.Update(categories))
            {
                return RedirectToAction("Index");
            }
            return View("Edit", categories);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int CategoryId)
        {
            var result = await _service.Get(CategoryId);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Destroy(Categories categories)
        {
            if (!ModelState.IsValid)
            {
                return View(categories);
            }
            if(await _service.Delete(categories))
            {
                return RedirectToAction("Index");
            }
            return View(categories);
        }

    }
}
