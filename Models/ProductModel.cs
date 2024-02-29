﻿using nguyenthaominhaspnet.Repository.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nguyenthaominhaspnet.Models
{
	public class ProductModel
	{
		[Key]
		public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên sản phẩm")]
		public string Name { get; set; }
		public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả sản phẩm")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập giá sản phẩm")]
        public decimal Price { get; set; }
		public int BrandId {  get; set; }
		public int CategoryId { get; set; }
		public CategoryModel Category {  get; set; }
		public BrandModel Brand { get; set; }
		public string Image { get; set; } = "noimage.jpg";
		[NotMapped]
		[FileExtension]
		public IFormFile ImageUpload { get; set; }
	}
}
