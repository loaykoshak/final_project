using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public float ProductPrice { get; set; }

        public int ProductCount { get; set; }

        public string? ProductColor { get; set; }

        public string image { get; set; }

        public DateTime ProductDate { get; set; }
    }
}
