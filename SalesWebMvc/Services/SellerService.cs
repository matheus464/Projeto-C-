using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;


namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context) 
        {
            this._context = context;
        }

        public List<Seller> FindAll() //operação sincrona, sistema fica bloqueado até rodar o comando no banco de dados;
        {
            return _context.Seller.ToList(); //acessa a fonte de dados na table seller e retorna uma lista com ToList()
        }
    }
}
