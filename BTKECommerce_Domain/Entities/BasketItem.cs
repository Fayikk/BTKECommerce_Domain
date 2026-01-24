using BTKECommerce_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKECommerce_Domain.Entities
{
    public class BasketItem : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid BasketId { get; set; }
        [ForeignKey(nameof(BasketId))]
        public Basket Basket { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
