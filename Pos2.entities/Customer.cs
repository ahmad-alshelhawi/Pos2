using System.ComponentModel.DataAnnotations;

namespace Pos2.entities
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}
