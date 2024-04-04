using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;
using System.Drawing;

namespace SalesWebMVC.Data
{
    public class SeedingService(SalesWebMVCContext context)
    {
        private SalesWebMVCContext _context = context;

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Random random = new();

            Department d1 = new("Computers");
            Department d2 = new("Electronics");
            Department d3 = new("Clothing");
            Department d4 = new("Books");
            Department d5 = new("Sports");

            Seller s1 = new("Bob Marley", "marley@gmail.com", new DateOnly(1994, 4, 22), 1200.0, d1);
            Seller s2 = new("Alice Smith", "alice@gmail.com", new DateOnly(1990, 5, 15), 1500.0, d2);
            Seller s3 = new("John Doe", "john@gmail.com", new DateOnly(1985, 10, 8), 1300.0, d3);
            Seller s4 = new("Emma Johnson", "emma@gmail.com", new DateOnly(1992, 8, 20), 1400.0, d4);
            Seller s5 = new("Michael Brown", "michael@gmail.com", new DateOnly(1988, 3, 25), 1250.0, d5);
            Seller s6 = new("Emily Davis", "emily@gmail.com", new DateOnly(1993, 7, 12), 1350.0, d1);
            Seller s7 = new("Daniel Wilson", "daniel@gmail.com", new DateOnly(1991, 6, 30), 1450.0, d2);
            Seller s8 = new("Olivia Martinez", "olivia@gmail.com", new DateOnly(1989, 9, 5), 1550.0, d3);
            Seller s9 = new("Matthew Taylor", "matthew@gmail.com", new DateOnly(1987, 2, 10), 1275.0, d4);
            Seller s10 = new("Sophia Anderson", "sophia@gmail.com", new DateOnly(1995, 11, 18), 1325.0, d5);

            SalesRecord r1 = new(new DateOnly(2023, 09, 11), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new(new DateOnly(2023, 09, 12), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new(new DateOnly(2023, 09, 13), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 8000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new(new DateOnly(2023, 09, 14), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 7500.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new(new DateOnly(2023, 09, 15), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 6000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new(new DateOnly(2023, 09, 16), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 5000.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new(new DateOnly(2023, 09, 17), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 4000.0, SaleStatus.Billed, s7);
            SalesRecord r8 = new(new DateOnly(2023, 09, 18), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 3000.0, SaleStatus.Billed, s8);
            SalesRecord r9 = new(new DateOnly(2023, 09, 19), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 2000.0, SaleStatus.Billed, s9);
            SalesRecord r10 = new(new DateOnly(2023, 09, 20), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 1000.0, SaleStatus.Billed, s10);
            SalesRecord r11 = new(new DateOnly(2023, 09, 21), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 5500.0, SaleStatus.Billed, s1);
            SalesRecord r12 = new(new DateOnly(2023, 09, 22), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 4800.0, SaleStatus.Billed, s2);
            SalesRecord r13 = new(new DateOnly(2023, 09, 23), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 4200.0, SaleStatus.Billed, s3);
            SalesRecord r14 = new(new DateOnly(2023, 09, 24), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 3700.0, SaleStatus.Billed, s4);
            SalesRecord r15 = new(new DateOnly(2023, 09, 25), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 3100.0, SaleStatus.Billed, s5);
            SalesRecord r16 = new(new DateOnly(2023, 09, 26), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 2500.0, SaleStatus.Billed, s6);
            SalesRecord r17 = new(new DateOnly(2023, 09, 27), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 1900.0, SaleStatus.Billed, s7);
            SalesRecord r18 = new(new DateOnly(2023, 09, 28), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 1300.0, SaleStatus.Billed, s8);
            SalesRecord r19 = new(new DateOnly(2023, 09, 29), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 700.0, SaleStatus.Billed, s9);
            SalesRecord r20 = new(new DateOnly(2023, 09, 30), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 300.0, SaleStatus.Billed, s10);
            SalesRecord r21 = new(new DateOnly(2023, 10, 01), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 5700.0, SaleStatus.Billed, s1);
            SalesRecord r22 = new(new DateOnly(2023, 10, 02), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 4900.0, SaleStatus.Billed, s2);
            SalesRecord r23 = new(new DateOnly(2023, 10, 03), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 4300.0, SaleStatus.Billed, s3);
            SalesRecord r24 = new(new DateOnly(2023, 10, 04), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 3800.0, SaleStatus.Billed, s4);
            SalesRecord r25 = new(new DateOnly(2023, 10, 05), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 3200.0, SaleStatus.Billed, s5);
            SalesRecord r26 = new(new DateOnly(2023, 10, 06), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 2600.0, SaleStatus.Billed, s6);
            SalesRecord r27 = new(new DateOnly(2023, 10, 07), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 2000.0, SaleStatus.Billed, s7);
            SalesRecord r28 = new(new DateOnly(2023, 10, 08), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 1400.0, SaleStatus.Billed, s8);
            SalesRecord r29 = new(new DateOnly(2023, 10, 09), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 800.0, SaleStatus.Billed, s9);
            SalesRecord r30 = new(new DateOnly(2023, 10, 10), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 400.0, SaleStatus.Billed, s10);
            SalesRecord r31 = new(new DateOnly(2023, 10, 11), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 5900.0, SaleStatus.Billed, s1);
            SalesRecord r32 = new(new DateOnly(2023, 10, 12), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r33 = new(new DateOnly(2023, 10, 13), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 4400.0, SaleStatus.Billed, s3);
            SalesRecord r34 = new(new DateOnly(2023, 10, 14), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 3900.0, SaleStatus.Billed, s4);
            SalesRecord r35 = new(new DateOnly(2023, 10, 15), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 3300.0, SaleStatus.Billed, s5);
            SalesRecord r36 = new(new DateOnly(2023, 10, 16), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 2700.0, SaleStatus.Billed, s6);
            SalesRecord r37 = new(new DateOnly(2023, 10, 17), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 2100.0, SaleStatus.Billed, s7);
            SalesRecord r38 = new(new DateOnly(2023, 10, 18), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 1500.0, SaleStatus.Billed, s8);
            SalesRecord r39 = new(new DateOnly(2023, 10, 19), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 900.0, SaleStatus.Billed, s9);
            SalesRecord r40 = new(new DateOnly(2023, 10, 20), new TimeOnly(random.Next(0, 24), random.Next(0, 60)), 500.0, SaleStatus.Billed, s10);

            _context.Department.AddRange(d1, d2, d3, d4, d5);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                              r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                              r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                              r31, r32, r33, r34, r35, r36, r37, r38, r39, r40);

            _context.SaveChanges();
        }
    }
}
