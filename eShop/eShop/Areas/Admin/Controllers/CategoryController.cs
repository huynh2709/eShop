using eShop.Areas.Admin.Controllers;
using eShop.Database;
using eShop.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers
{
    public class CategoryController : BaseController
    {

        public CategoryController(AddDbContext db):base(db)
        {
           
        }
        public IActionResult Index()
        {
            var data = _db.ProductCategories.OrderByDescending(c => c.Id);
            return View(data);
        }
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(ProductCategory category)
        {
            //luu vao db
            category.CreatedAt =DateTime.Now;
            category.UpdatedAt = DateTime.Now;
            _db.ProductCategories.Add(category);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}
