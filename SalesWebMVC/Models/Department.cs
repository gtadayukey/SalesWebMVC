using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = [];

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }

        public double TotalSales(DateOnly inicial, DateOnly final)
        {
            return Sellers.Sum(seller => seller.TotalSales(inicial, final));
        }
    }
}
