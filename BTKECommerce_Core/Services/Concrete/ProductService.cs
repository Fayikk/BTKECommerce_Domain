using AutoMapper;
using BTKECommerce_Core.Constants;
using BTKECommerce_Core.DTOs.Product;
using BTKECommerce_Core.Services.Abstract;
using BTKECommerce_Domain.Entities;
using BTKECommerce_Domain.Interfaces;
using BTKECommerce_Infrastructure.Models;

namespace BTKECommerce_Core.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public ProductService(IMapper mapper,IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public BaseResponseModel<bool> CreateProduct(ProductDTO model)
        {
            BaseResponseModel<bool> response = new();
            try
            {
                var obj = _mapper.Map<Product>(model);
                _productRepository.Add(obj);
                response.Message = Messages.SuccessCreateProduct;
                response.Data = true;
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = Messages.FailCreateProduct;
                response.Data = false;
                response.Success = false;
                return response;
            }
        }
    }
}
