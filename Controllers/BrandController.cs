using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nguyenthaominhaspnet.Models;
using nguyenthaominhaspnet.Repository;

namespace nguyenthaominhaspnet.Controllers
{
	public class BrandController: Controller
	{
		private readonly Datacontext _dataContext;
		public BrandController(Datacontext context)
		{
			_dataContext = context;
		}
		public async Task<IActionResult> Index(string Slug = "")
		{
			BrandModel brand = _dataContext.Brands.Where(c => c.Slug == Slug).FirstOrDefault();
			if (brand == null) return RedirectToAction("Index");
			var productsByBrand = _dataContext.Products.Where(p => p.BrandId == brand.Id);
			return View(await productsByBrand.OrderByDescending(p => p.Id).ToListAsync());
		}
		}
}
