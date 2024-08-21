using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayuot;
using EntityLayer;

namespace BussinesLayer
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<PRODUCT> Products()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
