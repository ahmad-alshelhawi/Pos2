using System.ComponentModel.DataAnnotations;

namespace Pos2.Models
{
    public class CategoryMapper
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "kjhj")]
        public string Name { get; set; }
        public DateOnly Date { get; set; }
    }

    public class CategoryCreateMapper
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateOnly date { get; set; }
    }
    public class CategoryUpdateMapper
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateOnly date { get; set; }

    }
    public class CategoryRemoveMapper
    {
        public int Id { get; set; }
    }
}
