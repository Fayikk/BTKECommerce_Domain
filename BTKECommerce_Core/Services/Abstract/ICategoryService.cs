using BTKECommerce_Core.DTOs.Category;
using BTKECommerce_Core.Models;
using BTKECommerce_Domain.Entities;
using BTKECommerce_Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKECommerce_Core.Services.Abstract
{
    public interface ICategoryService
    {
        BaseResponseModel<bool> CreateCategory(CategoryDTO model);
        BaseResponseModel<bool> DeleteCategory(Guid Id);
        BaseResponseModel<List<Category>> GetCategories();
        BaseResponseModel<Category> GetCategoryById(Guid Id);
        BaseResponseModel<Category> UpdateCategory(Guid Id, CategoryDTO model);
    }
}
