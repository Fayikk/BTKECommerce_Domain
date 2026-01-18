using BTKECommerce_Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BTKECommerce_Domain.Entities
{
    public class ProductImage : BaseEntity
    {
        public string ImageUrl { get; set; }
        public Guid ProductId { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}
