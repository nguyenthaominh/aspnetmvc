using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nguyenthaominhaspnet.Models;
using nguyenthaominhaspnet.Repository;

namespace nguyenthaominhaspnet.Repository.Components
{
	public class CategoriesViewComponent : ViewComponent
	{
		private readonly Datacontext _datacontext;

		public CategoriesViewComponent(Datacontext context)
		{
			_datacontext = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories = await _datacontext.Categories.ToListAsync();
			return View(categories);
		}
	}
}
