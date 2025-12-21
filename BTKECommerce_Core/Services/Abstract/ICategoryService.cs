using BTKECommerce_Core.DTOs.Category;
using BTKECommerce_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKECommerce_Core.Services.Abstract
{
    public interface ICategoryService
    {
        //List<CategoryModel> CreateCategory(CategoryDTO model);
        bool CreateCategory(CategoryDTO model);

        //List<CategoryModel> GetCategories();
        //List<CategoryModel> DeleteCategory(int Id);
        //CategoryModel UpdateCategory(int Id, CategoryModel model);
        //CategoryModel GetCategoryById(int Id);

    }
}
