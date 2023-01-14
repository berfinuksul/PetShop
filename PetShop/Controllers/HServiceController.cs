using Microsoft.AspNetCore.Mvc;
using PetShop.Data.Data;
using System.Linq;

namespace PetShop.Controllers
{
    public class HServiceController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HServiceController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var ObjList = _db.Services.ToList();
            return View(ObjList);
        }
    }
}
