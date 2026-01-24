using AutoMapper;
using BTKECommerce_Core.DTOs.Basket;
using BTKECommerce_Core.Services.Abstract;
using BTKECommerce_Domain.Entities;
using BTKECommerce_Infrastructure.UoW;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKECommerce_Core.Services.Concrete
{
    public class BasketService : IBasketService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BasketService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> AddToBasket(BasketDTO basketDTO)
        {
            var userBasket = await _unitOfWork.Baskets.GetAllAsyncExpression(
                predicate:x=>x.UserId == basketDTO.UserId,
                includeExpressions:x=>x.Include(x=>x.Items)
                );
            var userBasketUnique = userBasket.FirstOrDefault(x => x.UserId == basketDTO.UserId);

            if(userBasketUnique == null)
            {
                Basket basketObj = new()
                {
                    UserId = basketDTO.UserId,
                    Items = new List<BasketItem>()
                };
                _unitOfWork.Baskets.Add(basketObj);
            }else
            {
                var hasThisItem = userBasketUnique.Items.FirstOrDefault(x => x.ProductId == basketDTO.ProductId);
                if (hasThisItem != null)
                {
                    hasThisItem.Quantity = basketDTO.Quantity;
                }
                else
                {
                    _unitOfWork.BasketItems.Add(new BasketItem
                    {
                        ProductId = basketDTO.ProductId,
                        Quantity = basketDTO.Quantity,
                        BasketId = userBasketUnique.Id

                    });
                }
            }
            if(await _unitOfWork.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
