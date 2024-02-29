using Microsoft.AspNetCore.Mvc;
using nguyenthaominhaspnet.Repository;

namespace nguyenthaominhaspnet.Controllers
{
	public class ProductController : Controller
	{
		private readonly Datacontext _dataContext;
		public ProductController(Datacontext context)
		{
			_dataContext = context;
		}
		public ActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> Details(int? Id) {
			if (Id == null) return RedirectToAction("Index");
			var productById = _dataContext.Products.Where(p => p.Id == Id).FirstOrDefault();
				return View(productById);
			}
		}
}
