using BTKECommerce_Core.DTOs.Basket;
using BTKECommerce_Core.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTKECommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpPost]
        public async Task<IActionResult> AddToBasket(BasketDTO dto)
        {
            var result = await _basketService.AddToBasket(dto);
            return Ok(result);  
        }
    }
}
