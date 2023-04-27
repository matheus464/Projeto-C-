using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService // classe para popular o banco de dados
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context) 
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any()) 
            {
                return; //banco de dados já foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Browm", "bob@gmail.com", 2450.0 ,new DateTime(1998, 4, 21), d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", 2450.0 ,new DateTime(1998, 4, 21), d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", 2450.0 ,new DateTime(1998, 4, 21), d3);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", 2450.0 ,new DateTime(1998, 4, 21), d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", 2450.0 ,new DateTime(1998, 4, 21), d1);
            Seller s6 = new Seller(6, "Alex Pink", "alexpink@gmail.com", 2450.0 ,new DateTime(1998, 4, 21), d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2023, 4, 26), 1000.0, Models.Enums.SaleStatus.Biled, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2023, 4, 26), 2000.0, Models.Enums.SaleStatus.Biled, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2023, 4, 26), 3000.0, Models.Enums.SaleStatus.Biled, s3);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecords.AddRange(sr1, sr2, sr3);

            _context.SaveChanges();
        }
    }
}
