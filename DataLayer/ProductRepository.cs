using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLayuot
{
    public class ProductRepository
    {
        private readonly AppDBContext _context;

        public ProductRepository()
        {
            _context = new AppDBContext();
        }

        public List<PRODUCT> GetAllProducts()
        {
            var products = _context.PRODUCT.ToList();
            return products;
        }
    }
}
