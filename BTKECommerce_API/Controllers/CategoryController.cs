using BTKECommerce_Core.DTOs.Category;
using BTKECommerce_Core.Models;
using BTKECommerce_Core.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BTKECommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        //[HttpGet]
        //public async Task<IActionResult> GetCategories()
        //{
        //    return Ok(_categoryService.GetCategories());
        //}

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDTO model)
        {
           var isSaveChanges = _categoryService.CreateCategory(model);
            return Ok(isSaveChanges);
        }

        //[HttpDelete]
        //public async Task<IActionResult> DeleteCategory(int Id)
        //{
        //    var category = _categoryService.DeleteCategory(Id);
        //    return Ok(category);
        //}

        //[HttpPut]   
        //public async Task<IActionResult> UpdateCategory(CategoryModel model)
        //{
        //    var category = _categoryService.UpdateCategory(model.Id, model);
        //    return Ok(category);
        //}

        //[HttpGet("{Id}")]
        //public async Task<IActionResult> GetCategoryById([FromRoute]int Id)
        //{
        //    var category = _categoryService.GetCategoryById(Id);
        //    return Ok(category);
        //}



    }


  


}
