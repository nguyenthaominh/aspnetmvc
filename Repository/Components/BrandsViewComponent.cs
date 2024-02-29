using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nguyenthaominhaspnet.Models;
using nguyenthaominhaspnet.Repository;

namespace nguyenthaominhaspnet.Repository.Components
{
	public class BrandsViewComponent : ViewComponent
	{
		private readonly Datacontext _datacontext;

		public BrandsViewComponent(Datacontext context)
		{
			_datacontext = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories = await _datacontext.Brands.ToListAsync();
			return View(categories);
		}
	}
}
