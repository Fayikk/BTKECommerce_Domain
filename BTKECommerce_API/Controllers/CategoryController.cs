using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BTKECommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public List<CategoryModel> _categories = new List<CategoryModel>() 
        {
            new CategoryModel
            {
                Name = "Technology",
                Description = "Technology"
            },
            new CategoryModel
            {
                Name = "Computer",
                Description = "Computer"
            },
            new CategoryModel
            {
                Name = "Phone",
                Description = "Phone"
            },
            new CategoryModel
            {
                Name = "Clothes",
                Description = "Clothes"
            },
            };
        public CategoryController()
        {
        }


        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(_categories);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryModel model)
        {
            _categories.Add(model);

            return Ok(_categories);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(string name)
        {
            var category = _categories.FirstOrDefault(x => x.Name == name);
            _categories.Remove(category);
            return Ok(_categories);
        }


    }


    public class CategoryModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }


}
