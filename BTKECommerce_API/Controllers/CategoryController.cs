using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BTKECommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
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

        [HttpPut("{Id}")]   
        public async Task<IActionResult> UpdateCategory([FromRoute]int Id,CategoryModel model)
        {
            var category = _categories.FirstOrDefault(x => x.Id == Id);
            category.Name = model.Name;
            category.Description = model.Description;
            return Ok(category);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute]int Id)
        {
            CategoryModel category = _categories.FirstOrDefault(x => x.Id == Id);
            return Ok(category);
        }



    }


  


}
