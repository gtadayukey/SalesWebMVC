﻿using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellerService(SalesWebMVCContext context)
    {
        private readonly SalesWebMVCContext _context = context;

        public IEnumerable<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
