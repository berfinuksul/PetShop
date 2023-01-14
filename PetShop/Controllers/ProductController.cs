using Microsoft.AspNetCore.Mvc;
using PetShop.Data.Data;
using PetShop.Model.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var ObjList = _db.Products.ToList();
            return View(ObjList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var ob = await _db.Products.FindAsync(id);
            return View(ob);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product ob)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ob);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ob);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var obj = await _db.Products.FindAsync(id);
            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Products.FindAsync(id);
            _db.Products.Remove(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
