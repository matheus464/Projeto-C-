using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Exceptions;
using Microsoft.EntityFrameworkCore;


namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context) 
        {
            this._context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); //acessa a fonte de dados na table seller e retorna uma lista com ToList()
        }

        public void Insert(Seller obj) 
        {
  
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id) 
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id) 
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller seller) 
        {

            if (!_context.Seller.Any(x => x.Id == seller.Id)) 
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e) 
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
