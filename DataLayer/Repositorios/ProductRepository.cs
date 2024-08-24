using DataLayuot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Security.Cryptography.X509Certificates;

namespace DataLayuot.Repositorios
{
    public class ProductRepository : IProductRepository
    {
        public readonly AppDBContext _db;

        public ProductRepository(AppDBContext db)
        {
            _db = db;
        }


        public IEnumerable<PRODUCT> GetAll()
        {
            var products = new List<PRODUCT>();
            products = _db.PRODUCT.ToList();

            return products;
        }


        public PRODUCT GetById(int id)
        {
            var product = new PRODUCT();
            product = _db.PRODUCT.Where(p => p.PRODUCT_ID == id).FirstOrDefault();

            return product;
        }


        public void Create(PRODUCT product)
        {
            _db.PRODUCT.Add(product);
            _db.SaveChanges();
        }

        public void Update(PRODUCT product, int id)
        {
            var dbProduct = new PRODUCT();
            dbProduct = _db.PRODUCT.Where(p => p.PRODUCT_ID == id).FirstOrDefault();
            if (dbProduct != null)
            {
                dbProduct.NAME = product.NAME;
                dbProduct.DESCRIPTION = product.DESCRIPTION;
                dbProduct.BRAND_ID = product.BRAND_ID;
                dbProduct.BRAND_ID = product.BRAND_ID;
                dbProduct.CATEGORY_ID = product.CATEGORY_ID;
                dbProduct.STOCK = product.STOCK;
                dbProduct.IMG_PATH = product.IMG_PATH;
                dbProduct.IMG_NAME = product.IMG_NAME;
                dbProduct.AVAILABLE = product.AVAILABLE;
                _db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var dbProduct = new PRODUCT();
            dbProduct = _db.PRODUCT.Find(id);
            if(dbProduct != null)
            {
                _db.PRODUCT.Remove(dbProduct);
                _db.SaveChanges();
            }
        }

    }
}
