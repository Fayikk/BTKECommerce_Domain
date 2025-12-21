using BTKECommerce_Core.Models;
using BTKECommerce_Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKECommerce_Core.Services.Concrete
{
    public class CategoryService : ICategoryService
    {


        public List<CategoryModel> _categories = new List<CategoryModel>()
        {
            new CategoryModel
            {
                Id = 1,
                Name = "Technology",
                Description = "Technology"
            },
            new CategoryModel
            {
                Id = 2,
                Name = "Computer",
                Description = "Computer"
            },
            new CategoryModel
            {
                Id = 3,
                Name = "Phone",
                Description = "Phone"
            },
            new CategoryModel
            {
                Id = 4,
                Name = "Clothes",
                Description = "Clothes"
            },
            };

        public CategoryService()
        {
        }

        public List<CategoryModel> CreateCategory(CategoryModel model)
        {
            _categories.Add(model);
            return _categories;
        }

        public List<CategoryModel> DeleteCategory(int Id)
        {
            var category = _categories.FirstOrDefault(x => x.Id == Id);
            _categories.Remove(category);
            return _categories;
        }

        public List<CategoryModel> GetCategories()
        {
            return _categories;
        }

        public CategoryModel GetCategoryById(int Id)
        {
            var category = _categories.FirstOrDefault(x => x.Id == Id);
            return category;
        }

        public CategoryModel UpdateCategory(int Id, CategoryModel model)
        {
            CategoryModel category = _categories.FirstOrDefault(x => x.Id == Id);
            category.Description = model.Description;
            category.Name = model.Name;
            return category;
        }
    }
}
