using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellerService(SalesWebMVCContext context)
    {
        private readonly SalesWebMVCContext _context = context;

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id) 
        {
            return _context.Seller.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var seller = FindById(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }

    }
}
