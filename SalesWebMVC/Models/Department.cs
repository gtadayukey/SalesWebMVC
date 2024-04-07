namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
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
