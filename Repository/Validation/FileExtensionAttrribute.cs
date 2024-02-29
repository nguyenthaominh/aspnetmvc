using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

namespace nguyenthaominhaspnet.Repository.Validation
{
    public class FileExtensionAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if(value is IFormFile file)
            {
                var extension = Path.GetExtension(file.FileName);
                string[] extensions = { "jpg", "png","jpeg"};
                bool result=extension.Any(x=>extension.EndsWith(x));
                if(!result) 
                {
                    return new ValidationResult("Cho phép đuôi hình ảnh jpg, png hoặc jpeg");
                }
            }
            return ValidationResult.Success;
        }
    }
}
