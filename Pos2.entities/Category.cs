using System.ComponentModel.DataAnnotations;

namespace Pos2.entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public List<Product> Products { get; set; }
    }
}
