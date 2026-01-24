using BTKECommerce_Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTKECommerce_Domain.Entities
{
    public class Basket : BaseEntity
    {
        public string UserId { get; set;  }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}
