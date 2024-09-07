using DataLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repositorios
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
            try
            {
                IEnumerable<PRODUCT> productsDb = _db.PRODUCT.ToList();
                return productsDb; 
            }
            catch(Exception ex)
            {
                return Enumerable.Empty<PRODUCT>();
            }
        }


        public PRODUCT GetById(int id)
        {
            try
            {
                PRODUCT product = _db.PRODUCT.Where(p => p.PRODUCT_ID == id).FirstOrDefault();
                return product;
            } catch(Exception ex)
            {
                return null;
            }
        }


        public bool Create(PRODUCT product)
        {
            try
            {
                _db.PRODUCT.Add(product);
                _db.SaveChanges();

                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(PRODUCT product, int id)
        {
            try
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

                    return true;
                } else
                {
                    return false;
                }
            } catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var dbProduct = new PRODUCT();
            try
            {
                dbProduct = _db.PRODUCT.Find(id);
                if (dbProduct != null)
                {
                    _db.PRODUCT.Remove(dbProduct);
                    _db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
