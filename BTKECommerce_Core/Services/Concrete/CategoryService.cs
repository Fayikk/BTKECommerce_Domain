using AutoMapper;
using BTKECommerce_Core.DTOs.Category;
using BTKECommerce_Core.Models;
using BTKECommerce_Core.Services.Abstract;
using BTKECommerce_Domain.Data;
using BTKECommerce_Domain.Entities;

namespace BTKECommerce_Core.Services.Concrete
{
    public class CategoryService : ICategoryService
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CategoryService(IMapper mapper,ApplicationDbContext context)
        {
            _context = context; 
            _mapper = mapper;
        }

        public bool CreateCategory(CategoryDTO model)
        {
            var objDTO = _mapper.Map<Category>(model);
            _context.Categories.Add(objDTO);
            if(_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<CategoryModel> DeleteCategory(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryModel> GetCategories()
        {
            throw new NotImplementedException();
        }

        public CategoryModel GetCategoryById(int Id)
        {
            throw new NotImplementedException();
        }

        public CategoryModel UpdateCategory(int Id, CategoryModel model)
        {
            throw new NotImplementedException();
        }



        //public List<CategoryModel> DeleteCategory(int Id)
        //{
        //    var category = _categories.FirstOrDefault(x => x.Id == Id);
        //    _categories.Remove(category);
        //    return _categories;
        //}

        //public List<CategoryModel> GetCategories()
        //{
        //    return _categories;
        //}

        //public CategoryModel GetCategoryById(int Id)
        //{
        //    var category = _categories.FirstOrDefault(x => x.Id == Id);
        //    return category;
        //}

        //public CategoryModel UpdateCategory(int Id, CategoryModel model)
        //{
        //    CategoryModel category = _categories.FirstOrDefault(x => x.Id == Id);
        //    category.Description = model.Description;
        //    category.CategoryName = model.CategoryName;
        //    return category;
        //}
    }
}
