using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SalesRecordService(SalesWebMVCContext context)
    {
        private readonly SalesWebMVCContext _context = context;

        public async Task<List<SalesRecord>> FindByDateAsync(DateOnly? minDate, DateOnly? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(s => s.DateOnly >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(s => s.DateOnly <= maxDate.Value);
            }

            return await result
                .Include(s => s.Seller)
                .Include(s => s.Seller.Department)
                .OrderByDescending(s => s.DateOnly)
                .ToListAsync();
        }
    }
}
