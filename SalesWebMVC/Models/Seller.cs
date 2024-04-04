namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDay { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = [];

        public Seller() { }

        public Seller(string name, string email, DateOnly birthDay, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateOnly inicial, DateOnly final)
        {
            return Sales.Where(sr => sr.DateOnly >= inicial && sr.DateOnly <= final).Sum(sr => sr.Amount);
        }
    }
}
