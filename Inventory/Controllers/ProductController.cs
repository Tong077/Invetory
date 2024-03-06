using Inventory.Data;
using Inventory.Repositoy;
using Inventory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        private readonly EntityDbContext _dbcontex;

        public ProductController(IProductService service, EntityDbContext dbcontex)
        {
            _service = service;

            this._dbcontex = dbcontex;
        }   
   
        public async Task<IActionResult> Index()
        {
            var results = _service.GetAll();
            return View(await results);

        }

        [HttpGet]
        public IActionResult Create()
        {
            var categories = _dbcontex.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");

            return View("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Store(Products products)
        {
            if (!ModelState.IsValid)
            {
                return View(products);
            }
            if(await _service.Create(products))
            {
                return RedirectToAction("Index");
            }
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int ProductId)
        {
            var results =await _service.GetById(ProductId);
            return View(results);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Products products)
        {
            if(!ModelState.IsValid)
            {
                return View(products);
            }
            if(await _service.Update(products))
            {
                return RedirectToAction("Index");
            }
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult>Delete(int ProductId)
        {
            var results = await _service.GetById(ProductId);
            return View(results);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Products products)
        {
            if (!ModelState.IsValid)
            {
                return View(products);
            }
            if(await _service.Delete(products))
            {
                return RedirectToAction("Index");
            }
            return View(products);
        }
    }
}
