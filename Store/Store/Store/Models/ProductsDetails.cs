using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class ProductsDetails
    {
        [Key]
        public int Id { get; set; }

        public string? Description { get; set; }

        public string? DColor { get; set; }

        public string? DSize { get; set; }

        public string DScreen { get; set; }

        public string image { get; set; }
        public Products products { get; set; }
    }
}
