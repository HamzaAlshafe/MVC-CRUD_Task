using Microsoft.AspNetCore.Mvc;
using Task.Data;
using Task.Models;

namespace Task.Controllers
{
    public class ProductsController : Controller
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var products = context.products.ToList();
            return View(products);
        }

        public IActionResult Add() {
            return View(new Product());
        }

        public IActionResult Store(Product request)
        {
            if (ModelState.IsValid)
            {
                context.products.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Add",request);
            }
            
        }

    }
}
