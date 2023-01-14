using Microsoft.AspNetCore.Mvc;
using PetShop.Data.Data;
using PetShop.Model.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class AnimalController : Controller
    {

        private readonly ApplicationDbContext _db;
        public AnimalController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var ObjList = _db.Animals.ToList();
            return View(ObjList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Animal obj)
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
            var ob = await _db.Animals.FindAsync(id);
            return View(ob);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Animal ob)
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
            var obj = await _db.Animals.FindAsync(id);
            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Animals.FindAsync(id);
            _db.Animals.Remove(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
