using Microsoft.EntityFrameworkCore;
using nguyenthaominhaspnet.Models;
using nguyenthaominhaspnet.Repository;

namespace nguyenthaominhaspnet.Properties
{
	public class SeedData
	{
		public static void SeedingData(Datacontext _context)
		{
			_context.Database.Migrate();
			if(!_context.Products.Any())
			{
				CategoryModel iphone = new CategoryModel { Name = "Iphone", Slug = "iphone", Description = "Iphone is Large Product in the world", Status = 1 };
				CategoryModel flip = new CategoryModel { Name = "Flip", Slug = "flip", Description = "Flip is Large Product in the world", Status = 1 };
				BrandModel apple = new BrandModel { Name = "Apple", Slug = "apple", Description = "Apple is Large Brand in the world", Status = 1 };
				BrandModel samsung = new BrandModel { Name = "Samsung", Slug = "samsung", Description = "Samsung is Large Brand in the world", Status = 1 };
				_context.Products.AddRange(
					new ProductModel { Name = "Iphone13", Slug = "Iphone13", Description = "Iphone is Best", Image = "1.jpg", Category = iphone, Brand = apple, Price = 1233 },
					new ProductModel { Name = "FlipA1", Slug = "FlipA1", Description = "Flip is Best", Image = "1.jpg", Category = flip, Brand = samsung, Price = 345 }

					);
				_context.SaveChanges();

			}
		}
	}
}
