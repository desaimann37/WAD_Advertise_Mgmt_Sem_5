using Advertise_mgmt_system.Data;
using Advertise_mgmt_system.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Advertise_mgmt_system.Controllers
{
/*    [Authorize(Roles = "Admin")]
*/
    public class CategoryController : Controller
    {
        private readonly AuthDbContext _db;
        public CategoryController(AuthDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.CategoryDetails.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Adv_Name == obj.Adv_Theme)
            {
                ModelState.AddModelError("Name", "The Advertise Theme cannot exactly match the Advertise Name.");
            }
            if (ModelState.IsValid)
            {
                _db.CategoryDetails.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0) {
                return NotFound();
            }
            Category? categoryFromDb = _db.CategoryDetails.Find(id);
            /*
                Category? categoryFromDb1 = _db.CategoryDetails.FirstOrDefault(u => u.Id == id);
                Category? categoryFromDb2 = _db.CategoryDetails.Where(u => u.Id == id).FirstOrDefault();
            */

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        { 
            
            if (ModelState.IsValid)
            {  
                _db.CategoryDetails.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _db.CategoryDetails.Find(id);
            /*
                Category? categoryFromDb1 = _db.CategoryDetails.FirstOrDefault(u => u.Id == id);
                Category? categoryFromDb2 = _db.CategoryDetails.Where(u => u.Id == id).FirstOrDefault();
            */

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category obj = _db.CategoryDetails.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.CategoryDetails.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
         
        }
    }
}
