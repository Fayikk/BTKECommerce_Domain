using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKECommerce_Core.DTOs.Basket
{
    public class BasketResponseDTO
    {
        public string UserId { get; set; }
        public List<BasketItemResponseDTO> Items {  get; set; }
    }
}
