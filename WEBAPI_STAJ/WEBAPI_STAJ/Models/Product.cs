using System.ComponentModel.DataAnnotations;

namespace WEBAPI_STAJ.Models
{
    [Serializable]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
