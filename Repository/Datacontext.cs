﻿using Microsoft.EntityFrameworkCore;
using nguyenthaominhaspnet.Models;

namespace nguyenthaominhaspnet.Repository
{
	public class Datacontext:DbContext

	{
		public Datacontext(DbContextOptions<Datacontext> options) : base(options) {

		}
		public DbSet<BrandModel> Brands { get; set; }
		public DbSet<ProductModel> Products { get; set; }
		public DbSet<CategoryModel> Categories { get; set; }
	}
}
