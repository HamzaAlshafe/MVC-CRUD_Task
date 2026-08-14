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

        public IActionResult Edit(int id)
        {
            var product = context.products.Find(id);
            return View(product);
        }

        public IActionResult Update(Product request)
        {
            if (ModelState.IsValid)
            {
                context.products.Update(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", request);
            }
            
        }

        public IActionResult Delete(int id) {
            var product = context.products.Find(id);
            context.products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var product = context.products.Find(id);
            return View(product);
        }

    }
}
