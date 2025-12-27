using AutoMapper;
using BTKECommerce_Core.DTOs.Category;
using BTKECommerce_Core.Services.Abstract;
using BTKECommerce_Domain.Data;
using BTKECommerce_Domain.Entities;
using BTKECommerce_Infrastructure.Models;

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

        public BaseResponseModel<bool> CreateCategory(CategoryDTO model)
        {
            BaseResponseModel<bool> response = new BaseResponseModel<bool>();
            var objDTO = _mapper.Map<Category>(model);
            _context.Categories.Add(objDTO);
            if(_context.SaveChanges() > 0)
            {
                response.Data = true;
                response.Message = "Kategori başarıyla eklendi.";
                response.Success = true;
                return response;
            }
            return new BaseResponseModel<bool>
            {
                Data = false,
                Message = "Kategori eklenirken bir hata oluştu.",
                Success = false
            };
        }

        public BaseResponseModel<bool> DeleteCategory(Guid Id)
        {

            try
            {
                var obj = _context.Categories.FirstOrDefault(x => x.Id == Id);
                _context.Categories.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception (ex) as neede
                Console.WriteLine(ex.Message);
                return false;
            }

            
        }

        public BaseResponseModel<List<Category>> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public BaseResponseModel<Category> GetCategoryById(Guid Id)
        {

            //Önce parametreden gelen id'yi için Categories tablosundaki eşleşen kaydı bulacağız.
            Category category = _context.Categories.Find(Id);
            //Bulduğumuz kaydı döneceğiz.
            return category;

        }

        public BaseResponseModel<Category> UpdateCategory(Guid Id, CategoryDTO model)
        {
            //Önce parametreden gelen id'yi için Categories tablosundaki eşleşen kaydı bulacağız.
            Category category = _context.Categories.Find(Id);
            //mevcut verileri parametreden gelen güncel veriler ile güncelleyeceğiz.
            _mapper.Map(model, category);
            //context'e güncel nesneyi kaydedeceğiz.
            _context.Categories.Update(category);
            //veritabanına değişiklikleri kaydedeceğiz.
            if (_context.SaveChanges() > 0)
            {
                //güncellenen kategoriyi döneceğiz.
                return category;
            }
            return null;

        }



    }
}
