using SalesWebMVC.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateOnly DateOnly { get; set; }
        public TimeOnly TimeOnly { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(DateOnly dateOnly, TimeOnly timeOnly, double amount, SaleStatus status, Seller seller)
        {
            DateOnly = dateOnly;
            TimeOnly = timeOnly;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
