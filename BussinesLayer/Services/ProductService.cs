using BussinesLayer.Interfaces;
using DataLayer.Interfaces;
using EntityLayer;
using System.Collections.Generic;
using System.Linq;

namespace BussinesLayer.Services
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<PRODUCT> GetAllProducts()
        {
            List<PRODUCT> products = _productRepository.GetAll().ToList();

            return products;
        }

        public PRODUCT GetProductByID(int id)
        {
            PRODUCT product = _productRepository.GetById(id);
            return product;
        }

        public void CreateProduct(PRODUCT product)
        {
            _productRepository.Create(product);
        }

        public void UpdateProduct(PRODUCT product, int id)
        {
            _productRepository.Update(product, id);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }
    }
}
