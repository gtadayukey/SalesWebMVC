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

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateOnly? minDate, DateOnly? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.DateOnly >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DateOnly <= maxDate.Value);
            }

            var search = await result
            .Include(x => x.Seller)
            .Include(x => x.Seller.Department)
            .OrderByDescending(x => x.DateOnly)
            .ToListAsync();

            return search
                .GroupBy(x => x.Seller.Department).ToList();
        }
    }
}
