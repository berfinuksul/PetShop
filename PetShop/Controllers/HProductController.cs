using Microsoft.AspNetCore.Mvc;
using PetShop.Data.Data;
using System.Linq;

namespace PetShop.Controllers
{
	public class HProductController : Controller
	{
		private readonly ApplicationDbContext _db;
		public HProductController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			var ObjList = _db.Products.ToList();
			return View(ObjList);
		}
	}
}
