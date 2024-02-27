using System.ComponentModel.DataAnnotations;

namespace Pos2.entities
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public List<Sale_Product> SalesProducts { get; set; }

    }
}
